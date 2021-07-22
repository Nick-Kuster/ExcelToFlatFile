using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _072_XPARTFAENTITY
    {
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(12)]        
        public string Entity { get; set; }
    }
}
