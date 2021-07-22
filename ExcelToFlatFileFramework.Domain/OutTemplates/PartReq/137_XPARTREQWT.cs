using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _137_XPARTREQWT
    {
        [AmosOutputLength(38)]        
        public string PARTREQ_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string PARTREQ_TYPE { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
        [AmosOutputLength(1)]        
        public string EVENT_CLASS { get; set; }
        [AmosOutputLength(1)]        
        public string DEFECT_CLASS { get; set; }
        [AmosOutputLength(4)]        
        public string PRIO { get; set; }
        [AmosOutputLength(14)]        
        public string PROJECTNO { get; set; }
    }
}
