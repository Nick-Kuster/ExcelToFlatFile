using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelToFlatFileFramework.Domain.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    public class AmosAtLeastOneRequired : Attribute
    {
        public List<string> PropList { get; set; }
        public AmosAtLeastOneRequired(params string[] propList)
        {
            PropList = propList.ToList();
        }
    }
}