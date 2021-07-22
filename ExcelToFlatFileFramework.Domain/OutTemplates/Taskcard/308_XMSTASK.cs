using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _308_XMSTASK
    {
        [AmosOutputLength(25)]        
        public string MS_NAME { get; set; }
        [AmosOutputLength(38)]        
        public string TASKNUMBER { get; set; }
        [AmosOutputLength(1)]        
        public string OP_TASK { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
    }
}
