using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _351_XMSTASKPEND
    {
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(6)]        
        public string AcRegistr { get; set; }
        [AmosOutputLength(50)]        
        public string TaskcardNo { get; set; }
        [AmosOutputLength(12)]        
        public string TaskcardId { get; set; }
        [AmosOutputLength(36)]        
        public string EventIdentifier { get; set; }
    }
}
