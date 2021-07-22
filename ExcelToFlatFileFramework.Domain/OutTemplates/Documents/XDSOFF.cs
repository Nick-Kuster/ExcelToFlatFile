using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class XDSOFF
    {
        [AmosOutputLength(30)]        
        public string DOCNO_1 { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE_1 { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION_1 { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY_1 { get; set; }
        [AmosOutputLength(30)]        
        public string DOCNO_2 { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE_2 { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION_2 { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY_2 { get; set; }
    }
}
