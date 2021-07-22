using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _354_XMSTASKPRESET
    {
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(6)]        
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(2)]        
        public string DIMENSION { get; set; }
        [AmosOutputLength(10)]        
        public string AMOUNT_DUE { get; set; }
        [AmosOutputLength(4)]        
        public string DUE_DAY_TIME { get; set; }
        [AmosOutputLength(5)]        
        public string CHANGED_DATE { get; set; }
        [AmosOutputLength(4)]        
        public string CHANGED_TIME { get; set; }
        [AmosOutputLength(10)]        
        public string REQ_LINK_HEADERNO_OP { get; set; }
        [AmosOutputLength(50)]        
        public string TASKCARDNO { get; set; }
        [AmosOutputLength(12)]        
        public string TASKCARD_ID { get; set; }
    }
}
