using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _308_XMSTASK
    {
        [AmosOutputLength(25)]        
        public string MsName { get; set; }
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(1)]        
        public string OpTask { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
    }
}
