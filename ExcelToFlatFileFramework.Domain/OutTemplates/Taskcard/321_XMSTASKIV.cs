using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _321_XMSTASKIV
    {
        [AmosOutputLength(25)]        
        public string MsName { get; set; }
        [AmosOutputLength(8)]        
        public string MsIssue { get; set; }
        [AmosOutputLength(8)]        
        public string MsRevision { get; set; }
        [AmosOutputLength(38)]        
        public string TaskNumber { get; set; }
        [AmosOutputLength(1)]        
        public string OpTask { get; set; }
        [AmosOutputLength(8)]        
        public string TaskRevision { get; set; }
        [AmosOutputLength(2)]        
        public string Type { get; set; }
        [AmosOutputLength(2)]        
        public string DimType { get; set; }
        [AmosOutputLength(1)]        
        public string ThrBase { get; set; }
        [AmosOutputLength(20)]        
        public string DimGroup { get; set; }
        [AmosOutputLength(2)]        
        public string Dimension { get; set; }
        [AmosOutputLength(10)]        
        public string Amount { get; set; }
        [AmosOutputLength(2)]        
        public string ThrBaseDim { get; set; }
        [AmosOutputLength(10)]        
        public string ThrBaseAmount { get; set; }
        [AmosOutputLength(1)]        
        public string Unlimited { get; set; }
        [AmosOutputLength(1)]        
        public string Terminating { get; set; }
        [AmosOutputLength(1)]        
        public string CalcLogic { get; set; }
        [AmosOutputLength(4)]        
        public string CalcStrat { get; set; }
        [AmosOutputLength(1)]        
        public string AutoRepBack { get; set; }
        [AmosOutputLength(70)]        
        public string Notes { get; set; }
    }
}
