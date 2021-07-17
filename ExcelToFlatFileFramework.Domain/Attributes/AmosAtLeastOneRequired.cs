using System;

namespace ExcelToFlatFileFramework.Domain.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    public class AmosAtLeastOneRequired : Attribute
    {
        public AmosAtLeastOneRequired(params string[] propList)
        {
            
        }
    }
}