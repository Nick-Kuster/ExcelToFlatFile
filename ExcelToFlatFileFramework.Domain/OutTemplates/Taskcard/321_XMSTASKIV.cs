using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _321_XMSTASKIV
    {
        [AmosOutputLength(25)]        
        public string MS_NAME { get; set; }
        [AmosOutputLength(8)]        
        public string MS_ISSUE { get; set; }
        [AmosOutputLength(8)]        
        public string MS_REVISION { get; set; }
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(1)]        
        public string OP_TASK { get; set; }
        [AmosOutputLength(8)]        
        public string TASK_REVISION { get; set; }
        [AmosOutputLength(2)]        
        public string TYPE { get; set; }
        [AmosOutputLength(2)]        
        public string DIM_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string THR_BASE { get; set; }
        [AmosOutputLength(20)]        
        public string DIM_GROUP { get; set; }
        [AmosOutputLength(2)]        
        public string DIMENSION { get; set; }
        [AmosOutputLength(10)]        
        public string AMOUNT { get; set; }
        [AmosOutputLength(2)]        
        public string THR_BASE_DIM { get; set; }
        [AmosOutputLength(10)]        
        public string THR_BASE_AMOUNT { get; set; }
        [AmosOutputLength(1)]        
        public string UNLIMITED { get; set; }
        [AmosOutputLength(1)]        
        public string TERMINATING { get; set; }
        [AmosOutputLength(1)]        
        public string CALC_LOGIC { get; set; }
        [AmosOutputLength(4)]        
        public string CALC_STRAT { get; set; }
        [AmosOutputLength(1)]        
        public string AUTO_REP_BACK { get; set; }
        [AmosOutputLength(70)]        
        public string NOTES { get; set; }
    }
}
