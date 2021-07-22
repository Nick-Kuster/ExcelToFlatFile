using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _068_XPART
    {
        [AmosOutputLength(32)]        
        public string PartNo { get; set; }
        [AmosOutputLength(36)]        
        public string Description { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
        [AmosOutputLength(1)]        
        public string MaterialClass { get; set; }
        [AmosOutputLength(6)]        
        public string FaAcType { get; set; }
        [AmosOutputLength(12)]        
        public string Address { get; set; }
        [AmosOutputLength(6)]        
        public string StoreTime { get; set; }
        [AmosOutputLength(14)]        
        public string Weight { get; set; }
        [AmosOutputLength(14)]        
        public string AlertQty { get; set; }
        [AmosOutputLength(14)]        
        public string ReorderLevel { get; set; }
        [AmosOutputLength(14)]        
        public string MaxPurchQty { get; set; }
        [AmosOutputLength(4)]        
        public string MeasureUnit { get; set; }
        [AmosOutputLength(1)]        
        public string Tool { get; set; }
        [AmosOutputLength(1)]        
        public string Repairable { get; set; }
        [AmosOutputLength(16)]        
        public string Size { get; set; }
        [AmosOutputLength(50)]        
        public string DocumentRef { get; set; }
        [AmosOutputLength(36)]        
        public string Remarks { get; set; }
        [AmosOutputLength(12)]        
        public string DefaultSupplier { get; set; }
        [AmosOutputLength(12)]        
        public string DefaultRepair { get; set; }
        [AmosOutputLength(12)]        
        public string Manufacturer { get; set; }
        [AmosOutputLength(1)]        
        public string ReorderModel { get; set; }
        [AmosOutputLength(1)]        
        public string Status { get; set; }
        [AmosOutputLength(1)]        
        public string Ata200Convert { get; set; }
        [AmosOutputLength(4)]        
        public string MatType { get; set; }
        [AmosOutputLength(1)]        
        public string FixedAsset { get; set; }
        [AmosOutputLength(4)]        
        public string Origin { get; set; }
        [AmosOutputLength(4)]        
        public string MaxShopVisit { get; set; }
        [AmosOutputLength(8)]        
        public string SwResetCond { get; set; }
        [AmosOutputLength(50)]        
        public string Specifications { get; set; }
        [AmosOutputLength(15)]        
        public string ExtState { get; set; }
        [AmosOutputLength(14)]        
        public string SafetyStock { get; set; }
        [AmosOutputLength(1)]        
        public string Pma { get; set; }
        [AmosOutputLength(4)]        
        public string SpecialMeasureUn { get; set; }
        [AmosOutputLength(20)]        
        public string ResourceType { get; set; }
    }
}
