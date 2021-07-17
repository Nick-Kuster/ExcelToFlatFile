using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain
{
    public class ValidationBase
    {
        public List<string> Validate()
        {
            List<string> requiredPropsMissing = new List<string>();
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                string propertyName = propertyInfo.Name;
                object[] attributes = propertyInfo.GetCustomAttributes(typeof(AmosRequired), true);

                if (attributes.Length > 0)
                {
                    var propValue = propertyInfo.GetValue(this)?.ToString() == "UNK" ? "" : propertyInfo.GetValue(this)?.ToString();
                        
                    if (string.IsNullOrEmpty(propValue))
                    {
                        requiredPropsMissing.Add(propertyInfo.Name);
                    }
                }
            }

            return requiredPropsMissing;
        }
    }
}