using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _350_XMSTASKHIST
    {
        [AmosOutputLength(25)]        
        public string MsName { get; set; }
        [AmosOutputLength(8)]        
        public string MsIssue { get; set; }
        [AmosOutputLength(8)]        
        public string MsRevision { get; set; }
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(1)]        
        public string OpTask { get; set; }
        [AmosOutputLength(8)]        
        public string TaskRevision { get; set; }
        [AmosOutputLength(50)]        
        public string TaskcardNo { get; set; }
        [AmosOutputLength(12)]        
        public string TaskcardId { get; set; }
        [AmosOutputLength(6)]        
        public string AcRegistr { get; set; }
        [AmosOutputLength(8)]        
        public string MechSign { get; set; }
        [AmosOutputLength(4)]        
        public string ReleaseStation { get; set; }
        [AmosOutputLength(6)]        
        public string ReleaseTime { get; set; }
        [AmosOutputLength(10)]        
        public string DueTah { get; set; }
        [AmosOutputLength(10)]        
        public string PerfTah { get; set; }
        [AmosOutputLength(6)]        
        public string DueTac { get; set; }
        [AmosOutputLength(6)]        
        public string PerfTac { get; set; }
        [AmosOutputLength(10)]        
        public string DueDate { get; set; }
        [AmosOutputLength(10)]        
        public string PerfDate { get; set; }
        [AmosOutputLength(200)]        
        public string UniqueId { get; set; }
        [AmosOutputLength(36)]        
        public string EventIdentifier { get; set; }
        [AmosOutputLength(1000)]        
        public string Remarks { get; set; }
    }
}
