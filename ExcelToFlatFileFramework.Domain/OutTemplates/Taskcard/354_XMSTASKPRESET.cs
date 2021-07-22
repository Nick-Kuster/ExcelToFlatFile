using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _354_XMSTASKPRESET
    {
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(6)]        
        public string AcRegistr { get; set; }
        [AmosOutputLength(2)]        
        public string Dimension { get; set; }
        [AmosOutputLength(10)]        
        public string AmountDue { get; set; }
        [AmosOutputLength(4)]        
        public string DueDayTime { get; set; }
        [AmosOutputLength(5)]        
        public string ChangedDate { get; set; }
        [AmosOutputLength(4)]        
        public string ChangedTime { get; set; }
        [AmosOutputLength(10)]        
        public string ReqLinkHeaderNoOp { get; set; }
        [AmosOutputLength(50)]        
        public string TaskcardNo { get; set; }
        [AmosOutputLength(12)]        
        public string TaskcardId { get; set; }
    }
}
