using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _309_XMSTASKRV
    {
        [AmosOutputLength(25)]        
        public string MS_NAME { get; set; }
        [AmosOutputLength(8)]        
        public string MS_ISSUE { get; set; }
        [AmosOutputLength(8)]        
        public string MS_REVISION { get; set; }
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(1)]        
        public string OP_TASK { get; set; }
        [AmosOutputLength(250)]        
        public string TITLE { get; set; }
        [AmosOutputLength(8)]        
        public string TASK_REVISION { get; set; }
        [AmosOutputLength(10)]        
        public string TASK_REVISION_DATE { get; set; }
        [AmosOutputLength(255)]        
        public string TASK_REVISION_REASON { get; set; }
        [AmosOutputLength(10)]        
        public string RELEASE_DATE { get; set; }
        [AmosOutputLength(4)]        
        public string COMPLIANCE { get; set; }
        [AmosOutputLength(1)]        
        public string STATUS { get; set; }
        [AmosOutputLength(1)]        
        public string TASK_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string INTERVAL_TYPE { get; set; }
        [AmosOutputLength(6)]        
        public string MAXRECURRENCE { get; set; }
        [AmosOutputLength(1)]        
        public string NOT { get; set; } //APPLICABLE
        [AmosOutputLength(8)]        
        public string MRB_REVISION { get; set; }
        [AmosOutputLength(10)]        
        public string MRB_REVISION_DATE { get; set; }
        [AmosOutputLength(255)]        
        public string MRB_REVISION_REASON { get; set; }
        [AmosOutputLength(6)]        
        public string EST_MH_MRB { get; set; }
        [AmosOutputLength(1)]        
        public string REQ_MAND_REP { get; set; }
        [AmosOutputLength(2)]        
        public string CRX_REV_FLAG { get; set; }
        [AmosOutputLength(10)]        
        public string CP_SEQ { get; set; }
        [AmosOutputLength(1)]        
        public string STATE { get; set; }
        [AmosOutputLength(500)]        
        public string EFF_NOTES { get; set; }
        [AmosOutputLength(1000)]        
        public string NOTES { get; set; }
        [AmosOutputLength(1500)]        
        public string MRB_TEXT { get; set; }
        [AmosOutputLength(3000)]        
        public string REMARKS { get; set; }
    }
}
