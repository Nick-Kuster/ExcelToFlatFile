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
        public string CHECK_TYPE { get; set; }
        [AmosOutputLength(22)]        
        public string INTERNAL_CHECK { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(6)]        
        public string AIRCRAFT { get; set; }
        [AmosOutputLength(1)]        
        public string NEVER_PERFORMED { get; set; }
        [AmosOutputLength(2)]        
        public string CONTROL_DIM_1 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_1 { get; set; }
        [AmosOutputLength(2)]        
        public string CONTROL_DIM_2 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_2 { get; set; }
        [AmosOutputLength(2)]        
        public string CONTROL_DIM_3 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_3 { get; set; }
        [AmosOutputLength(36)]        
        public string EVENT_IDENTIFIER { get; set; }
    }
}
