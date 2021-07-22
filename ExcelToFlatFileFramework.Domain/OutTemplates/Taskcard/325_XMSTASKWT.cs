using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _325_XMSTASKWT
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
        [AmosOutputLength(8)]        
        public string TASK_REVISION { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
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
