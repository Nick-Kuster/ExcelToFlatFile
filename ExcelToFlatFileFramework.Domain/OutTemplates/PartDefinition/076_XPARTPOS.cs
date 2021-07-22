using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _076_XPARTPOS
    {
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(6)]        
        public string AC_TYPE { get; set; }
        [AmosOutputLength(14)]        
        public string POSITION { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
    }
}
