using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _148_XPARTREQHI
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
        [AmosOutputLength(10)]
        public string PerfDate { get; set; } 
        [AmosOutputLength(2)]
        public string ControlDim { get; set; } 
        [AmosOutputLength(10)]
        public string DueAmount { get; set; } 
        [AmosOutputLength(10)]
        public string PerfAmount { get; set; } 
        [AmosOutputLength(200)]
        public string UniqueId { get; set; } 
        [AmosOutputLength(36)]
        public string EventIdentifier { get; set; } 
    }
}
