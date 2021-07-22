using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _351_XMSTASKPEND
    {
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(6)]        
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(50)]        
        public string TASKCARDNO { get; set; }
        [AmosOutputLength(12)]        
        public string TASKCARD_ID { get; set; }
        [AmosOutputLength(36)]        
        public string EVENT_IDENTIFIER { get; set; }
    }
}
