using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _339_XMSTASKITEF
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
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
    }
}
