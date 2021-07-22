using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _118_XEFF
    {
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitlePar { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitleHigh { get; set; }
        [AmosOutputLength(6)]        
        public string AcType { get; set; }
        [AmosOutputLength(6)]        
        public string AcModel { get; set; }
        [AmosOutputLength(6)]        
        public string AcSub { get; set; }
        [AmosOutputLength(6)]        
        public string EffAcType { get; set; }
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(2)]        
        public string SerType { get; set; }
        [AmosOutputLength(1)]        
        public string Changeable { get; set; }
        [AmosOutputLength(70)]        
        public string Description { get; set; }
    }
}
