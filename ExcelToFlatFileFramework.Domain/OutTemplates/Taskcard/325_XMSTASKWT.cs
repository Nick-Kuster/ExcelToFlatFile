using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _325_XMSTASKWT
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
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
        [AmosOutputLength(1)]        
        public string EventClass { get; set; }
        [AmosOutputLength(1)]        
        public string DefectClass { get; set; }
        [AmosOutputLength(4)]        
        public string Prio { get; set; }
        [AmosOutputLength(14)]        
        public string ProjectNo { get; set; }
    }
}
