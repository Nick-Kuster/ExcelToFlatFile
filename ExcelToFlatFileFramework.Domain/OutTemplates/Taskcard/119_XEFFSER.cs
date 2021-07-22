using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _119_XEFFSER
    {
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(1)]        
        public string RangeType { get; set; }
        [AmosOutputLength(20)]        
        public string SerialNoFrom { get; set; }
        [AmosOutputLength(20)]        
        public string SerialNoTo { get; set; }
        [AmosOutputLength(1)]        
        public string InclExcl { get; set; }
        [AmosOutputLength(1)]        
        public string SerShift { get; set; }
    }
}
