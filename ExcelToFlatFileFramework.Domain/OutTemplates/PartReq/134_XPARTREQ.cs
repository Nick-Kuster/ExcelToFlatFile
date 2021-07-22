using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _134_XPARTREQ
    {
        [AmosOutputLength(38)]        
        public string PartReqTitle { get; set; }
        [AmosOutputLength(2)]        
        public string PartReqType { get; set; }
        [AmosOutputLength(36)]        
        public string Description { get; set; }
        [AmosOutputLength(1)]        
        public string RemovalReq { get; set; }
        [AmosOutputLength(1)]        
        public string ShelfPerf { get; set; }
        [AmosOutputLength(4)]        
        public string HardSoft { get; set; }
        [AmosOutputLength(1)]        
        public string ProRata { get; set; }
        [AmosOutputLength(10)]        
        public string Rating { get; set; }
    }
}
