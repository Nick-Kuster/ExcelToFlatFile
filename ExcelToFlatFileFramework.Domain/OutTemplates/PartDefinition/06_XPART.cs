using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _06_XPART
    {
        public string PARTNO { get; set; } //[32][m]
        public string Description { get; set; } //[36][m]
        public string ATA_CHAPTER { get; set; } //[12][m]
        public string MATERIAL_CLASS { get; set; } //[1][m]
        public string FA_AC_TYPE { get; set; } //[6][m]
        public string ADDRESS { get; set; } //[12]
        public string STORETIME { get; set; } //[6]
        public string WEIGHT { get; set; } //[14]
        public string ALERT_QTY { get; set; } //[14]
        public string REORDER_LEVEL { get; set; } //[14]
        public string MAX_PURCH_QTY { get; set; } //[14]
        public string MEASURE_UNIT { get; set; } //[4]
        public string TOOL { get; set; } //[1]
        public string REPAIRABLE { get; set; } //[1]
        public string SIZE { get; set; } //[16]
        public string DOCUMENT_REF { get; set; } //[50]
        public string REMARKS { get; set; } //[36]
        public string DEFAULT_SUPPLIER { get; set; } //[12]
        public string DEFAULT_REPAIR { get; set; } //[12]
        public string MANUFACTURER { get; set; } //[12]
        public string REORDER_MODEL { get; set; } //[1]
        public string STATUS { get; set; } //[1]
        public string ATA200_CONVERT { get; set; } //[1]
        public string MAT_TYPE { get; set; } //[4][m]
        public string FIXED_ASSET { get; set; } //[1]
        public string ORIGIN { get; set; } //[4]
        public string MAX_SHOP_VISIT { get; set; } //[4]
        public string SW_RESET_COND { get; set; } //[8]
        public string SPECIFICATIONS { get; set; } //[50]
        public string EXT_STATE { get; set; } //[15]
        public string SAFETY_STOCK { get; set; } //[14]
        public string PMA { get; set; } //[1]
        public string SPECIAL_MEASURE_UN { get; set; } //[4]
        public string RESOURCE_TYPE { get; set; } //[20]
    }
}
