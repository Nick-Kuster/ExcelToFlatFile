using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _134_XPARTREQ
    {
        [AmosOutputLength(38)]        
        public string PARTREQ_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string PARTREQ_TYPE { get; set; }
        [AmosOutputLength(36)]        
        public string DESCRIPTION { get; set; }
        [AmosOutputLength(1)]        
        public string REMOVAL_REQ { get; set; }
        [AmosOutputLength(1)]        
        public string SHELF_PERF { get; set; }
        [AmosOutputLength(4)]        
        public string HARD_SOFT { get; set; }
        [AmosOutputLength(1)]        
        public string PRO_RATA { get; set; }
        [AmosOutputLength(10)]        
        public string RATING { get; set; }
    }
}
