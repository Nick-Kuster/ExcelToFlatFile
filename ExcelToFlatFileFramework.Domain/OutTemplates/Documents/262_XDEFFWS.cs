using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _262_XDEFFWS
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
        public string SEQ_NO { get; set; }
        [AmosOutputLength(1)]        
        public string WS_TYPE { get; set; }
        [AmosOutputLength(70)]        
        public string HEADER { get; set; }
        [AmosOutputLength(8)]        
        public string SIGN { get; set; }
        [AmosOutputLength(1)]        
        public string CRITICAL { get; set; }
        [AmosOutputLength(1)]        
        public string DEFUEL { get; set; }
        [AmosOutputLength(1)]        
        public string DOUBLE_INSP { get; set; }
        [AmosOutputLength(1)]        
        public string EL_POWER { get; set; }
        [AmosOutputLength(1)]        
        public string EVENT_OPEN { get; set; }
        [AmosOutputLength(1)]        
        public string EWIS { get; set; }
        [AmosOutputLength(1)]        
        public string EXT_HYDR { get; set; }
        [AmosOutputLength(1)]        
        public string HYDR_OFF { get; set; }
        [AmosOutputLength(1)]        
        public string IDLE_RUN { get; set; }
        [AmosOutputLength(1)]        
        public string INSURANCE { get; set; }
        [AmosOutputLength(1)]        
        public string NDT { get; set; }
        [AmosOutputLength(1)]        
        public string POWER_RUN { get; set; }
        [AmosOutputLength(1)]        
        public string TANK_ENTRY { get; set; }
        [AmosOutputLength(1)]        
        public string TEST_FLIGHT { get; set; }
        [AmosOutputLength(1)]        
        public string TROUBLESHOOTING { get; set; }
        [AmosOutputLength(1)]        
        public string WARRANTY { get; set; }
        [AmosOutputLength(1)]        
        public string ETOPS { get; set; }
        [AmosOutputLength(1)]        
        public string AD { get; set; }
        [AmosOutputLength(15)]        
        public string PHASE { get; set; }
        [AmosOutputLength(4)]        
        public string WS_REV { get; set; }
        [AmosOutputLength(1)]        
        public string REV_STATUS { get; set; }
        [AmosOutputLength(1500)]        
        public string TEXT { get; set; }
        [AmosOutputLength(1000)]        
        public string COMMENT { get; set; }
    }
}
