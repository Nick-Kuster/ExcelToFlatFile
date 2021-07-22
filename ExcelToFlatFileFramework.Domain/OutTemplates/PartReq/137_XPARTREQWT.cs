using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _137_XPARTREQWT
    {
        [AmosOutputLength(38)]        
        public string PartReqTitle { get; set; }
        [AmosOutputLength(2)]        
        public string PartReqType { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
        [AmosOutputLength(1)]        
        public string EventClass { get; set; }
        [AmosOutputLength(1)]        
        public string DefectClass { get; set; }
        [AmosOutputLength(4)]        
        public string Prio { get; set; }
        [AmosOutputLength(14)]        
        public string ProjectNo { get; set; }
    }
}
