using System;
using System.IO;
using System.Linq;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using OfficeOpenXml;

namespace ExcelToFlatFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var excel1 = @"C:\Users\nickk\OneDrive\Desktop\Airmost\ExcelToFlatFile\Part Template - example.xlsx";
            var excel2 = @"C:\Users\nickk\OneDrive\Desktop\Airmost\ExcelToFlatFile\269_XDPEND_EAL_S&D (1).xlsx";
            //ReadFromExcel();
            using (var package = new ExcelPackage(new FileInfo(excel1)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var firstSheet = package.Workbook.Worksheets["Sheet1"];
                Console.WriteLine("Sheet 1 Data");
                var start = firstSheet.Dimension.Start;
                var end = firstSheet.Dimension.End;
                var sb = new StringBuilder();
                for (int row = start.Row; row <= end.Row; row++)
                { // Row by row...
                    if (row < 3) continue;
                    for (int col = start.Column; col <= end.Column; col++)
                    { // ... Cell by cell...
                        var cellValue = firstSheet.Cells[row, col].Text; // This got me the actual value I needed.
                        var cell = firstSheet.Cells[row, col]; // This got me the actual value I needed.
                        var width = (int)Math.Floor(firstSheet.Column(col).Width);
                        var whiteSpace = width - cellValue.Length;
                        var newValue = cellValue.PadRight(whiteSpace);
                        sb.Append(cellValue);
                        for(int i = 0; i < whiteSpace; i++)
                        {
                            sb.Append(" ");
                        }
                        //sb.Append(newValue);
                    }
                    sb.Append("\n");
                }

                File.WriteAllText(@"C:\Users\nickk\OneDrive\Desktop\Airmost\ExcelToFlatFile\Text.txt", sb.ToString());
            }

            //var xlApp = new Application();
            //var xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\nickk\Downloads\269_XDPEND_EAL_S&D.xlsx", 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            //var xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            ////var worksheet = wb.Worksheets[0];
            ////Get the used Range
            //Microsoft.Office.Interop.Excel.Range usedRange = xlWorkSheet.UsedRange;

            ////Iterate the rows in the used range
            //foreach (Microsoft.Office.Interop.Excel.Range row in usedRange.Rows)
            //{
            //    //Do something with the row.

            //    //Ex. Iterate through the row's data and put in a string array
            //    String[] rowData = new String[row.Columns.Count];
            //    for (int i = 0; i < row.Columns.Count; i++)
            //    {
            //        var r = row;
            //        //rowData[i] = Convert.ToString(row.Cells[1, i + 1].Value2);

            //    }
            //}
        }

        public static void ReadFromExcel()
        {
            using (var excel = SpreadsheetDocument.Open(@"C:\Users\nickk\OneDrive\Desktop\Airmost\ExcelToFlatFile\Part Template - example.xlsx", false))
            {

                var sheets = excel.WorkbookPart.WorksheetParts;

                // Loop through each of the sheets in the spreadsheet
                foreach (var wp in sheets)
                {
                    Worksheet worksheet = wp.Worksheet;

                    // Loop through each of the rows in the current sheet
                    var rows = worksheet.GetFirstChild<SheetData>().Elements<Row>().ToList();
                    for (int i = 2; i < rows.Count(); i++)
                    {
                        // Loop through each of the cells in the current row.
                        var row = rows[i].Elements<Cell>().ToList();

                        foreach (var cell in row)
                        {
                            var aircraft = row[0].CellValue.Text;
                            // Here is where you would do something with the values of the spreadsheet.
                            string str = cell.CellValue.Text;
                        }
                    }
                }

                excel.Close();
            }
        }
    }
}
