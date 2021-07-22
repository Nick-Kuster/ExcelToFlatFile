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
        public string DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY { get; set; }
        [AmosOutputLength(6)]        
        public string AC_TYPE { get; set; }
    }
}
