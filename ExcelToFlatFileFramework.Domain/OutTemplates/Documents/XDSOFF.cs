using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _XDSOFF
    {
        [AmosOutputLength(30)]        
        public string Docno1 { get; set; }
        [AmosOutputLength(6)]        
        public string DocType1 { get; set; }
        [AmosOutputLength(4)]        
        public string Revision1 { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy1 { get; set; }
        [AmosOutputLength(30)]        
        public string Docno2 { get; set; }
        [AmosOutputLength(6)]        
        public string DocType2 { get; set; }
        [AmosOutputLength(4)]        
        public string Revision2 { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy2 { get; set; }
    }
}
