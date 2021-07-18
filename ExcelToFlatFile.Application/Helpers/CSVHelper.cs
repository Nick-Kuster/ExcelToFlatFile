using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ExcelToFlatFile.Application.Helpers
{
    public class CSVHelper
    {
        public void WriteErrorsCSV<T>(Dictionary<T, string> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path))
            {
                var headings = string.Join(", ", props.Select(p => p.Name)) + ", Errors";
                writer.WriteLine(headings);

                foreach (var item in items.Keys)
                {
                    var row = string.Join(", ", props.Select(p =>
                    {
                        var returnVal = p.GetValue(item, null)?.ToString();
                        return returnVal?.Replace(',', '|');
                    })) + $", {items[item]}";
                    writer.WriteLine(row);
                }
            }
        }
    }
}