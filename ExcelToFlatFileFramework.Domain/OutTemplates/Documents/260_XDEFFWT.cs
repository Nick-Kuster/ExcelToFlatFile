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
        public string DocNo { get; set; }
        [AmosOutputLength(6)]        
        public string DocType { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(4)]        
        public string WtRevision { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
        [AmosOutputLength(1)]        
        public string EventClass { get; set; }
        [AmosOutputLength(1)]        
        public string DefectClass { get; set; }
        [AmosOutputLength(4)]        
        public string Prio { get; set; }
        [AmosOutputLength(14)]        
        public string ProjectNo { get; set; }
    }
}
