using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain
{
    public class ValidationBase
    {
        public List<string> ValidateRequiredProps()
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

        public List<List<string>> ValidateAtLeastOnePropRequired()
        {
            List<List<string>> requiredPropsMissing = new List<List<string>>();
            var atLeastOneRequiredAttributes = Attribute.GetCustomAttributes(GetType(), typeof(AmosAtLeastOneRequired));

            foreach (var att in atLeastOneRequiredAttributes)
            {
                if (att is AmosAtLeastOneRequired typedAtt)
                {
                    var valid = false;
                    var propList = typedAtt.PropList.Select(x => GetType().GetProperty(x)?.GetValue(this));
                    foreach (var propName in typedAtt.PropList)
                    {
                        PropertyInfo prop = GetType().GetProperty(propName);
                        var value = prop?.GetValue(this)?.ToString();
                        
                        valid = !string.IsNullOrEmpty(value);
                        if (valid)
                        {
                            break;
                        }
                    }

                    if (!valid)
                    {
                        requiredPropsMissing.Add(typedAtt.PropList);
                    }
                }
            }

            return requiredPropsMissing;
        }
    }
}