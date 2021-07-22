using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _260_XDEFFWT
    {
        [AmosOutputLength(25)]        
        public string DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(4)]        
        public string WT_REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
        [AmosOutputLength(1)]        
        public string EVENT_CLASS { get; set; }
        [AmosOutputLength(1)]        
        public string DEFECT_CLASS { get; set; }
        [AmosOutputLength(4)]        
        public string PRIO { get; set; }
        [AmosOutputLength(14)]        
        public string PROJECTNO { get; set; }
    }
}
