using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _147_XPARTREQTC
    {
        [AmosOutputLength(38)]        
        public string PARTREQ_TITLE { get; set; }
        [AmosOutputLength(2)]        
        public string PARTREQ_TYPE { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(25)]        
        public string MS_NAME { get; set; }
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(12)]        
        public string OPERATOR { get; set; }
        [AmosOutputLength(2)]        
        public string PRINT_MODE { get; set; }
    }
}
