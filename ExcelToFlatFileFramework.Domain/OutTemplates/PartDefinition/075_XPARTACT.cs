using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _075_XPARTACT
    {
        [AmosOutputLength(32)]      
        public string PartNo { get; set; }
        [AmosOutputLength(80)]        
        public string IpcReference { get; set; }
        [AmosOutputLength(6)]        
        public string AcType { get; set; }
    }
}
