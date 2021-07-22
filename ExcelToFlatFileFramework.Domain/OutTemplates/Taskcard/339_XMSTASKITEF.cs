using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _339_XMSTASKITEF
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
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
    }
}
