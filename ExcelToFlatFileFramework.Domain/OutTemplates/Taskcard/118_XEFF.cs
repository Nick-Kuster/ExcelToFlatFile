using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _118_XEFF
    {
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE_PAR { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE_HIGH { get; set; }
        [AmosOutputLength(6)]        
        public string AC_TYPE { get; set; }
        [AmosOutputLength(6)]        
        public string AC_MODEL { get; set; }
        [AmosOutputLength(6)]        
        public string AC_SUB { get; set; }
        [AmosOutputLength(6)]        
        public string EFF_AC_TYPE { get; set; }
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(2)]        
        public string SER_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string CHANGEABLE { get; set; }
        [AmosOutputLength(70)]        
        public string DESCRIPTION { get; set; }
    }
}
