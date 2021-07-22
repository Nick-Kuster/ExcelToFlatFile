using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _135_XPARTREQEFFLINK
    {
        [AmosOutputLength(38)]        
        public string PARTREQ_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string PARTREQ_TYPE { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
    }
}
