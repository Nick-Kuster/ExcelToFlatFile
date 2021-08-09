using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ClosedXML.Excel;
using ExcelToFlatFileFramework.Domain.Attributes;
using Npoi.Mapper.Attributes;

namespace ExcelToFlatFile.Application.TemplateGenerators
{
    public static class TemplateGenerator
    {
        public static void Generate<T>(string templateName, string templateDirectory)
        {
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet templateWorksheet = workbook.Worksheets.Add($"{templateName}");
                IXLWorksheet rulesWorksheet = workbook.Worksheets.Add($"{templateName} Rules");
                var atLeastOneRequiredAttributes = Attribute.GetCustomAttributes(typeof(T), typeof(AmosAtLeastOneRequired));

                var j = 0;
                if (atLeastOneRequiredAttributes.Any())
                {
                    rulesWorksheet.Cell(4, 1).Value = "At least one of the values is required in the following groups:";


                    foreach (var att in atLeastOneRequiredAttributes)
                    {
                        if (att is AmosAtLeastOneRequired typedAtt)
                        {
                            rulesWorksheet.Cell(5 + j, 1).Value = string.Join(",", typedAtt.PropList?.ToArray() ?? new string[0]);
                        }

                        ++j;
                    }
                }

                var i = 1;
                foreach (PropertyInfo propertyInfo in typeof(T).GetProperties())
                {
                    StringBuilder sb = new StringBuilder();

                    Attribute length = propertyInfo.GetCustomAttribute(typeof(AmosOutputLength), true);
                    if (length is AmosOutputLength outLengthTypedAtt)
                    {
                        sb.Append($"[{outLengthTypedAtt.Length}]");
                    }
                    Attribute required = propertyInfo.GetCustomAttribute(typeof(AmosRequired), true);
                    if (required is AmosRequired requiredTypedAtt)
                    {
                        sb.Append("[m]");
                    }

                    Attribute columnName = propertyInfo.GetCustomAttribute(typeof(ColumnAttribute), true);
                    if (columnName is ColumnAttribute columnNameTypedAtt)
                    {
                        rulesWorksheet.Cell(1, i).Value = $"{columnNameTypedAtt.Name}{sb}";
                        templateWorksheet.Cell(1, i).Value = columnNameTypedAtt.Name;
                    }

                    ++i;
                }

                rulesWorksheet.Columns().AdjustToContents();
                templateWorksheet.Columns().AdjustToContents();
                Directory.CreateDirectory(templateDirectory);
                workbook.SaveAs($"{templateDirectory}\\{templateName}.xlsx");
            }
        }
    }
}
