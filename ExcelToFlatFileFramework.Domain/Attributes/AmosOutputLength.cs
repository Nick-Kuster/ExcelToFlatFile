using System;

namespace ExcelToFlatFileFramework.Domain.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field)]
    public class AmosOutputLength : Attribute
    {
        public int Length { get; set; }
        public AmosOutputLength(int length)
        {
            Length = length;
        }
    }
}