using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFile.Application.Helpers
{
    public class ConvertOutTemplateToStringHelper
    {
        public string ConvertToString<T>(List<T> listToConvert)
        {
            StringBuilder sb = new StringBuilder();
            foreach (T item
                in listToConvert)
            {
                foreach (PropertyInfo propertyInfo in item.GetType().GetProperties())
                {
                    string propertyName = propertyInfo.Name;
                    object[] attributes = propertyInfo.GetCustomAttributes(typeof(AmosOutputLength), true);
                
                    if (attributes.Length > 0)
                    {
                        var attr = (AmosOutputLength)attributes[0];
                        var length = attr.Length;
                        var propValue =propertyInfo.GetValue(item)?.ToString() ?? null;
                        sb.Append(propValue);
                        var whiteSpace = length - propValue?.Length;
                        for (int i = 0; i < whiteSpace; i++)
                        {
                            sb.Append(" ");
                        }
                    }
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}