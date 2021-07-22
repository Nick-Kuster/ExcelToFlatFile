using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _268_XDHIST
    {
        [AmosOutputLength(25)]        
        public string DocNo { get; set; }
        [AmosOutputLength(6)]        
        public string DocType { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy { get; set; }
        [AmosOutputLength(70)]        
        public string EffTitle { get; set; }
        [AmosOutputLength(6)]        
        public string AcRegistr { get; set; }
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(20)]        
        public string SerialNumber { get; set; }
        [AmosOutputLength(10)]        
        public string PerfHours { get; set; }
        [AmosOutputLength(6)]        
        public string PerfCycles { get; set; }
        [AmosOutputLength(10)]        
        public string PerfDate { get; set; }
        [AmosOutputLength(2)]        
        public string Dim1 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount1 { get; set; }
        [AmosOutputLength(10)]        
        public string PerfAmount1 { get; set; }
        [AmosOutputLength(2)]        
        public string Dim2 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount2 { get; set; }
        [AmosOutputLength(10)]        
        public string PerfAmount2 { get; set; }
        [AmosOutputLength(2)]        
        public string Dim3 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount3 { get; set; }
        [AmosOutputLength(10)]        
        public string PerfAmount3 { get; set; }
        [AmosOutputLength(1)]        
        public string PerfStatus { get; set; }
        [AmosOutputLength(1)]        
        public string PartlyPerf { get; set; }
        [AmosOutputLength(25)]        
        public string PerfRefDoc { get; set; }
        [AmosOutputLength(20)]        
        public string PerfCustomerWo { get; set; }
        [AmosOutputLength(15)]        
        public string UniqueRotId { get; set; }
        [AmosOutputLength(1)]        
        public string IsLastHistory { get; set; }
        [AmosOutputLength(36)]        
        public string EventIdentifier { get; set; }
        [AmosOutputLength(2500)]        
        public string PerfText { get; set; }
    }
}
