using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _352_XMSTASKPENDINT
    {
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(6)]        
        public string AcRegistr { get; set; }
        [AmosOutputLength(2)]        
        public string Dimension { get; set; }
        [AmosOutputLength(10)]        
        public string AmountDue { get; set; }
        [AmosOutputLength(50)]        
        public string TaskcardNo { get; set; }
        [AmosOutputLength(12)]        
        public string TaskcardId { get; set; }
    }
}
