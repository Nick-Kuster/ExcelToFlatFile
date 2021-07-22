using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _075_XPARTACT
    {
        [AmosOutputLength(32)]      
        public string PARTNO { get; set; }
        [AmosOutputLength(80)]        
        public string IPC_REFERENCE { get; set; }
        [AmosOutputLength(6)]        
        public string AC_TYPE { get; set; }
    }
}
