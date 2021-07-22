
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _136_XPARTREQTREQ
    {
        [AmosOutputLength(38)]        
        public string PartReqTitle { get; set; }
        [AmosOutputLength(2)]        
        public string PartReqType { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(2)]        
        public string DimType { get; set; }
        [AmosOutputLength(1)]        
        public string ThrBase { get; set; }
        [AmosOutputLength(1)]        
        public string Fl { get; set; }
        [AmosOutputLength(2)]        
        public string Dim { get; set; }
        [AmosOutputLength(10)]        
        public string Amount { get; set; }
        [AmosOutputLength(2)]        
        public string ThrBase0Dim { get; set; }
        [AmosOutputLength(10)]        
        public string ThrBaseAmount { get; set; }
        [AmosOutputLength(1)]        
        public string Unlimited { get; set; }
        [AmosOutputLength(1)]        
        public string Terminating { get; set; }
        [AmosOutputLength(4)]        
        public string CalcStrat { get; set; }
        [AmosOutputLength(1)]        
        public string AutoRepBack { get; set; }
        [AmosOutputLength(70)]        
        public string Notes { get; set; }
    }
}
