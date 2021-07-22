using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _352_XMSTASKPENDINT
    {
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(6)]        
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(2)]        
        public string DIMENSION { get; set; }
        [AmosOutputLength(10)]        
        public string AMOUNT_DUE { get; set; }
        [AmosOutputLength(50)]        
        public string TASKCARDNO { get; set; }
        [AmosOutputLength(12)]        
        public string TASKCARD_ID { get; set; }
    }
}
