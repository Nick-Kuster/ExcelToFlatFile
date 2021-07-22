using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _068_XPART
    {
        [AmosOutputLength(32)]        
        public string PARTNO { get; set; }
        [AmosOutputLength(36)]        
        public string Description { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
        [AmosOutputLength(1)]        
        public string MATERIAL_CLASS { get; set; }
        [AmosOutputLength(6)]        
        public string FA_AC_TYPE { get; set; }
        [AmosOutputLength(12)]        
        public string ADDRESS { get; set; }
        [AmosOutputLength(6)]        
        public string STORETIME { get; set; }
        [AmosOutputLength(14)]        
        public string WEIGHT { get; set; }
        [AmosOutputLength(14)]        
        public string ALERT_QTY { get; set; }
        [AmosOutputLength(14)]        
        public string REORDER_LEVEL { get; set; }
        [AmosOutputLength(14)]        
        public string MAX_PURCH_QTY { get; set; }
        [AmosOutputLength(4)]        
        public string MEASURE_UNIT { get; set; }
        [AmosOutputLength(1)]        
        public string TOOL { get; set; }
        [AmosOutputLength(1)]        
        public string REPAIRABLE { get; set; }
        [AmosOutputLength(16)]        
        public string SIZE { get; set; }
        [AmosOutputLength(50)]        
        public string DOCUMENT_REF { get; set; }
        [AmosOutputLength(36)]        
        public string REMARKS { get; set; }
        [AmosOutputLength(12)]        
        public string DEFAULT_SUPPLIER { get; set; }
        [AmosOutputLength(12)]        
        public string DEFAULT_REPAIR { get; set; }
        [AmosOutputLength(12)]        
        public string MANUFACTURER { get; set; }
        [AmosOutputLength(1)]        
        public string REORDER_MODEL { get; set; }
        [AmosOutputLength(1)]        
        public string STATUS { get; set; }
        [AmosOutputLength(1)]        
        public string ATA200_CONVERT { get; set; }
        [AmosOutputLength(4)]        
        public string MAT_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string FIXED_ASSET { get; set; }
        [AmosOutputLength(4)]        
        public string ORIGIN { get; set; }
        [AmosOutputLength(4)]        
        public string MAX_SHOP_VISIT { get; set; }
        [AmosOutputLength(8)]        
        public string SW_RESET_COND { get; set; }
        [AmosOutputLength(50)]        
        public string SPECIFICATIONS { get; set; }
        [AmosOutputLength(15)]        
        public string EXT_STATE { get; set; }
        [AmosOutputLength(14)]        
        public string SAFETY_STOCK { get; set; }
        [AmosOutputLength(1)]        
        public string PMA { get; set; }
        [AmosOutputLength(4)]        
        public string SPECIAL_MEASURE_UN { get; set; }
        [AmosOutputLength(20)]        
        public string RESOURCE_TYPE { get; set; }
    }
}
