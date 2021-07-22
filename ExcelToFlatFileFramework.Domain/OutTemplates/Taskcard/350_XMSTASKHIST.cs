using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _350_XMSTASKHIST
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
        [AmosOutputLength(50)]        
        public string TASKCARDNO { get; set; }
        [AmosOutputLength(12)]        
        public string TASKCARD_ID { get; set; }
        [AmosOutputLength(6)]        
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(8)]        
        public string MECH_SIGN { get; set; }
        [AmosOutputLength(4)]        
        public string RELEASE_STATION { get; set; }
        [AmosOutputLength(6)]        
        public string RELEASE_TIME { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_TAH { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_TAH { get; set; }
        [AmosOutputLength(6)]        
        public string DUE_TAC { get; set; }
        [AmosOutputLength(6)]        
        public string PERF_TAC { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_DATE { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_DATE { get; set; }
        [AmosOutputLength(200)]        
        public string UNIQUE_ID { get; set; }
        [AmosOutputLength(36)]        
        public string EVENT_IDENTIFIER { get; set; }
        [AmosOutputLength(1000)]        
        public string REMARKS { get; set; }
    }
}
