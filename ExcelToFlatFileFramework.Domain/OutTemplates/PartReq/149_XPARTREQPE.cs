using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _149_XPARTREQPE 
    {
        [AmosOutputLength(38)]
        public string PartReqTitle { get; set; } 
        [AmosOutputLength(2)]
        public string PartReqType { get; set; } 
        [AmosOutputLength(70)]
        public string EffTitle { get; set; } 
        [AmosOutputLength(32)]
        public string PartNo { get; set; } 
        [AmosOutputLength(20)]
        public string SerialNo { get; set; } 
        [AmosOutputLength(2)]
        public string Dimension { get; set; } 
        [AmosOutputLength(10)]
        public string DueAmount { get; set; } 
        [AmosOutputLength(36)]
        public string EventIdentifier { get; set; }
    }
}