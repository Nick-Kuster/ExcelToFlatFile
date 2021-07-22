using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _268_XDHIST
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
        [AmosOutputLength(10)]        
        public string PERF_HOURS { get; set; }
        [AmosOutputLength(6)]        
        public string PERF_CYCLES { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_DATE { get; set; }
        [AmosOutputLength(2)]        
        public string DIM_1 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_1 { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_AMOUNT_1 { get; set; }
        [AmosOutputLength(2)]        
        public string DIM_2 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_2 { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_AMOUNT_2 { get; set; }
        [AmosOutputLength(2)]        
        public string DIM_3 { get; set; }
        [AmosOutputLength(10)]        
        public string DUE_AMOUNT_3 { get; set; }
        [AmosOutputLength(10)]        
        public string PERF_AMOUNT_3 { get; set; }
        [AmosOutputLength(1)]        
        public string PERF_STATUS { get; set; }
        [AmosOutputLength(1)]        
        public string PARTLY_PERF { get; set; }
        [AmosOutputLength(25)]        
        public string PERF_REFDOC { get; set; }
        [AmosOutputLength(20)]        
        public string PERF_CUSTOMER_WO { get; set; }
        [AmosOutputLength(15)]        
        public string UNIQUE_ROT_ID { get; set; }
        [AmosOutputLength(1)]        
        public string IS_LAST_HISTORY { get; set; }
        [AmosOutputLength(36)]        
        public string EVENT_IDENTIFIER { get; set; }
        [AmosOutputLength(2500)]        
        public string PERF_TEXT { get; set; }
    }
}
