using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _135_XPARTREQEFFLINK
    {
        [AmosOutputLength(38)]        
        public string PartReqTitle { get; set; }
        [AmosOutputLength(2)]        
        public string PartReqType { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
    }
}
