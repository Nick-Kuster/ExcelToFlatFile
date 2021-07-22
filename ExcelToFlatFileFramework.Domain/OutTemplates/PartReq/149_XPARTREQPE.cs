using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _149_XPARTREQPE 
    {
        [AmosOutputLength(38)]
        public string PARTREQ_TITLE { get; set; } 
        [AmosOutputLength(2)]
        public string PARTREQ_TYPE { get; set; } 
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; } 
        [AmosOutputLength(32)]
        public string PARTNO { get; set; } 
        [AmosOutputLength(20)]
        public string SERIALNO { get; set; } 
        [AmosOutputLength(2)]
        public string DIMENSION { get; set; } 
        [AmosOutputLength(10)]
        public string DUE_AMOUNT { get; set; } 
        [AmosOutputLength(36)]
        public string EVENT_IDENTIFIER { get; set; }
    }
}