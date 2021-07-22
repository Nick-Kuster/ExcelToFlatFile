using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _082_XPARTWT
    {
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }

    }
}
