using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _082_XPARTWT
    {
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }

    }
}
