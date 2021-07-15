using ExcelToFlatFileFramework.Attributes;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework
{
    public class Program
    {
        static void Main(string[] a5rgs)
        {
            //var fileName = @"C:\Documentation\Templates\InTemplates\Part Template - example EDITED FOR IMPORT.xlsx";
            //var fileName = @"C:\Documentation\Templates\InTemplates\Document template EDITED FOR IMPORT.xlsx";
            //var fileName = @"C:\Documentation\Templates\InTemplates\Checks Template.xlsx";
            var fileName = @"C:\Documentation\Templates\InTemplates\Taskcard Template.xlsx";
            //var excel2 = @"C:\Users\nickk\OneDrive\Desktop\Airmost\ExcelToFlatFile\269_XDPEND_EAL_S&D (1).xlsx";
            
            DataTable sheetData = new DataTable();
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;"))
            {
                conn.Open();
                // retrieve the data using data adapter
                OleDbDataAdapter sheetAdapter = new OleDbDataAdapter("select distinct * from [" + "Sheet1" + "$]", conn);
                sheetAdapter.Fill(sheetData);
                //List<PartTemplate> tests = new List<PartTemplate>();
                //List<DocumentTemplate> tests = new List<DocumentTemplate>();
                //List<ChecksTemplate> tests = new List<ChecksTemplate>();
                List<TaskcardTemplate> tests = new List<TaskcardTemplate>();
                List<string> colNames = new List<string>();
                foreach(DataColumn col in sheetData.Columns)
                {
                    Regex rgx = new Regex("[\\s-]+");
                    var normalized = rgx.Replace(col.ColumnName, "_");
                    colNames.Add(normalized);
                }
                foreach(DataRow row in sheetData.Rows)
                {
                    //PartTemplate newTest = new PartTemplate();
                    //DocumentTemplate newTest = new DocumentTemplate();
                    //ChecksTemplate newTest = new ChecksTemplate();
                    TaskcardTemplate newTest = new TaskcardTemplate();
                    foreach (DataColumn col in sheetData.Columns)
                    {
                        Regex rgx = new Regex("[\\s-]+");
                        var normalized = rgx.Replace(col.ColumnName.Trim(), "_");
                        var cellValue = row[col];
                        if (row[col] is DBNull dbNull)
                        {
                            cellValue = null;
                        }
                        newTest.GetType().GetProperty(normalized, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance)?.SetValue(newTest, cellValue?.ToString(), null);
                    }
                    tests.Add(newTest);
                }
                var acmodel = tests.FirstOrDefault(x => x.AC_MODEL == "800BCF");
                foreach (var test in tests)
                {
                    foreach (PropertyInfo propertyInfo in test.GetType().GetProperties())
                    {
                        string propertyName = propertyInfo.Name;

                        object[] attributes = propertyInfo.GetCustomAttributes(typeof(AmosRules), true);
                        // Just in case you have a property without this annotation
                        for(int i = 0; i < attributes.Length; i++)
                        {
                            AmosRules myAttribute = (AmosRules)attributes[i];
                            switch (myAttribute.AmosRuleType)
                            {
                                case AmosRuleType.Required:
                                    var x = propertyInfo.GetValue(test);
                                    var type = x?.GetType();
                                    object defaultVal = null;
                                    if (type != null)
                                    {
                                        defaultVal = type.IsValueType ? Activator.CreateInstance(type) : null;
                                    }
                                    var valid = x != defaultVal;

                                    break;
                                case AmosRuleType.RequiredLength:
                                    var y = propertyInfo.GetValue(test);
                                    break;
                                default:
                                    break;
                            }
                        }
                        
                    }
                }
                conn.Close();
            }
            
            
        }

        public class Test
        {
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 32)]
            public string Aircraft { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 12)]
            public string ATA { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 32)]
            public string PartNumber { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 20)]
            public string SerialNumber { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 36)]
            public string Description { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 14)]
            public string Position { get; set; }
            [AmosRules(AmosRuleType.RequiredLength, 50)]
            public string DocumentRefNo { get; set; }
            [AmosRules(AmosRuleType.Required)]
            [AmosRules(AmosRuleType.RequiredLength, 38)]
            public string PartReqTitle { get; set; }
        }
    }
}

