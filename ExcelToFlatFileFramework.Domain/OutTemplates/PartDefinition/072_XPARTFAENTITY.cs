using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _072_XPARTFAENTITY
    {
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(12)]        
        public string ENTITY { get; set; }
    }
}
