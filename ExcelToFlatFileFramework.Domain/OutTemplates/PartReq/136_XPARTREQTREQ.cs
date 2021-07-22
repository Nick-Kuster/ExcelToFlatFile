
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _136_XPARTREQTREQ
    {
        [AmosOutputLength(38)]        
        public string PARTREQ_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string PARTREQ_TYPE { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string DIM_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string THR_BASE { get; set; }
        [AmosOutputLength(1)]        
        public string FL { get; set; }
        [AmosOutputLength(2)]        
        public string DIM { get; set; }
        [AmosOutputLength(10)]        
        public string AMOUNT { get; set; }
        [AmosOutputLength(2)]        
        public string THR_BASE0DIM { get; set; }
        [AmosOutputLength(10)]        
        public string THR_BASE_AMOUNT { get; set; }
        [AmosOutputLength(1)]        
        public string UNLIMITED { get; set; }
        [AmosOutputLength(1)]        
        public string TERMINATING { get; set; }
        [AmosOutputLength(4)]        
        public string CALC_STRAT { get; set; }
        [AmosOutputLength(1)]        
        public string AUTO_REP_BACK { get; set; }
        [AmosOutputLength(70)]        
        public string NOTES { get; set; }
    }
}
