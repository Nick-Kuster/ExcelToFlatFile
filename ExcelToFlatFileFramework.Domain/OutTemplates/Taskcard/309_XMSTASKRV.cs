using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _309_XMSTASKRV
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
        [AmosOutputLength(250)]        
        public string Title { get; set; }
        [AmosOutputLength(8)]        
        public string TaskRevision { get; set; }
        [AmosOutputLength(10)]        
        public string TaskRevisionDate { get; set; }
        [AmosOutputLength(255)]        
        public string TaskRevisionReason { get; set; }
        [AmosOutputLength(10)]        
        public string ReleaseDate { get; set; }
        [AmosOutputLength(4)]        
        public string Compliance { get; set; }
        [AmosOutputLength(1)]        
        public string Status { get; set; }
        [AmosOutputLength(1)]        
        public string TaskType { get; set; }
        [AmosOutputLength(1)]        
        public string IntervalType { get; set; }
        [AmosOutputLength(6)]        
        public string MaxRecurrence { get; set; }
        [AmosOutputLength(1)]        
        public string NotApplicable { get; set; } 
        [AmosOutputLength(8)]        
        public string MrbRevision { get; set; }
        [AmosOutputLength(10)]        
        public string MrbRevisionDate { get; set; }
        [AmosOutputLength(255)]        
        public string MrbRevisionReason { get; set; }
        [AmosOutputLength(6)]        
        public string EstMhMrb { get; set; }
        [AmosOutputLength(1)]        
        public string ReqMandRep { get; set; }
        [AmosOutputLength(2)]        
        public string CrxRevFlag { get; set; }
        [AmosOutputLength(10)]        
        public string CpSeq { get; set; }
        [AmosOutputLength(1)]        
        public string State { get; set; }
        [AmosOutputLength(500)]        
        public string EffNotes { get; set; }
        [AmosOutputLength(1000)]        
        public string Notes { get; set; }
        [AmosOutputLength(1500)]        
        public string MrbText { get; set; }
        [AmosOutputLength(3000)]        
        public string Remarks { get; set; }
    }
}
