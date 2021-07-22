using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _147_XPARTREQTC
    {
        [AmosOutputLength(38)]        
        public string PartReqTitle { get; set; }
        [AmosOutputLength(2)]        
        public string PartReqType { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(25)]        
        public string MsName { get; set; }
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(12)]        
        public string Operator { get; set; }
        [AmosOutputLength(2)]        
        public string PrintMode { get; set; }
    }
}
