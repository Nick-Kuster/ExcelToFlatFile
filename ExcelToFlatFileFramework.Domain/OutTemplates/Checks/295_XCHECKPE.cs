using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _295_XCHECKPE
    {
        [AmosOutputLength(20)]        
        public string CheckType { get; set; }
        [AmosOutputLength(22)]        
        public string InternalCheck { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(6)]        
        public string Aircraft { get; set; }
        [AmosOutputLength(1)]        
        public string NeverPerformed { get; set; }
        [AmosOutputLength(2)]        
        public string ControlDim1 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount1 { get; set; }
        [AmosOutputLength(2)]        
        public string ControlDim2 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount2 { get; set; }
        [AmosOutputLength(2)]        
        public string ControlDim3 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount3 { get; set; }
        [AmosOutputLength(36)]        
        public string EventIdentifier { get; set; }
    }
}
