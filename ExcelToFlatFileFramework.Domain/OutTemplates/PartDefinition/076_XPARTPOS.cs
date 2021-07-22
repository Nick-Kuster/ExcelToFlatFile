using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _076_XPARTPOS
    {
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(6)]        
        public string AcType { get; set; }
        [AmosOutputLength(14)]        
        public string Position { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
    }
}
