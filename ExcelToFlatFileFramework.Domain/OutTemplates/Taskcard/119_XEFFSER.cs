using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _119_XEFFSER
    {
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(1)]        
        public string RANGE_TYPE { get; set; }
        [AmosOutputLength(20)]        
        public string SERIALNO_FROM { get; set; }
        [AmosOutputLength(20)]        
        public string SERIALNO_TO { get; set; }
        [AmosOutputLength(1)]        
        public string INCL_EXCL { get; set; }
        [AmosOutputLength(1)]        
        public string SER_SHIFT { get; set; }
    }
}
