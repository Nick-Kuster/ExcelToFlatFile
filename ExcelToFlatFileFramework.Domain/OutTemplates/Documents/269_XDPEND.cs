using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _269_XDPEND
    {
        [AmosOutputLength(25)]        
        public string DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(6)]        
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(20)]        
        public string SERIALNUMBER { get; set; }
        [AmosOutputLength(2)]        
        public string DUE_DIM_1 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_1 { get; set; }
        [AmosOutputLength(2)]        
        public string DUE_DIM_2 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_2 { get; set; }
        [AmosOutputLength(2)]        
        public string DUE_DIM_3 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_3 { get; set; }
        [AmosOutputLength(1)]        
        public string OPEN_STATUS { get; set; }
        [AmosOutputLength(20)]        
        public string DUE_CUSTOMER_WO { get; set; }
        [AmosOutputLength(36)]        
        public string EVENT_IDENTIFIER { get; set; }

    }
}
