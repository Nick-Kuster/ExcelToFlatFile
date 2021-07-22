using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _241_XDCOMPACTYPE
    {
        [AmosOutputLength(25)]        
        public string DocNo { get; set; }
        [AmosOutputLength(6)]        
        public string DocType { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy { get; set; }
        [AmosOutputLength(6)]        
        public string AcType { get; set; }
    }
}
