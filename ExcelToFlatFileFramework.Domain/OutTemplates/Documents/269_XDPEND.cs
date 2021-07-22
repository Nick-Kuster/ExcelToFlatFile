using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _269_XDPEND
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
        [AmosOutputLength(2)]        
        public string DueDim1 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount1 { get; set; }
        [AmosOutputLength(2)]        
        public string DueDim2 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount2 { get; set; }
        [AmosOutputLength(2)]        
        public string DueDim3 { get; set; }
        [AmosOutputLength(10)]        
        public string DueAmount3 { get; set; }
        [AmosOutputLength(1)]        
        public string OpenStatus { get; set; }
        [AmosOutputLength(20)]        
        public string DueCustomerWo { get; set; }
        [AmosOutputLength(36)]        
        public string EventIdentifier { get; set; }

    }
}
