using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;
using ExcelToFlatFileFramework.Domain.Enums;
using Npoi.Mapper.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    // [AmosAtLeastOneRequired("LAST_REQ_TSN", "LAST_REQ_CYCLES", "LAST_REQ_DATE")]
    // [AmosAtLeastOneRequired("NEXT_DUE_FH", "NEXT_DUE_FC", "NEXT_DUE_DATE")]
    // [AmosAtLeastOneRequired("DELIVERY_DATE", "INSTALLATION_DATE")]
    public class PartTemplate : ValidationBase
    {
        [AmosRequired]
        [Column("Aircraft")]
        public string Aircraft { get; set; }
        [Column("ATA")]
        public string ATA { get; set; }
        [AmosRequired]
        [Column("PART NUMBER")]
        public string PART_NUMBER { get; set; }
        [AmosRequired]
        [Column("SERIAL NUMBER")]
        public string SERIAL_NUMBER { get; set; }
        [AmosRequired]
        [Column("DESCRIPTION")]
        public string DESCRIPTION { get; set; }
        [AmosRequired]
        [Column("Position")]
        public string Position { get; set; }
        [Column("TASKCARD REFERENCE")]
        public string TaskcardReference { get; set; }
        [AmosRequired]
        [Column("Part Req Title")]
        public string Part_Req_Title { get; set; }
        [AmosRequired]
        [Column("Eff Title")]
        public string Eff_Title { get; set; }
        [Column("Part Req Description")]
        public string Part_Req_Description { get; set; }
        [AmosRequired]
        [Column("REQUIREMENT")]
        public string REQUIREMENT { get; set; }
        [Column("Removal Req")]
        public string Removal_Req { get; set; }
        [Column("RANGE-TYPE")]
        public string RANGE_TYPE { get; set; }
        [Column("SERIALNO-FROM")]
        public string SERIALNO_FROM { get; set; }
        [Column("SERIALNO-TO")]
        public string SERIALNO_TO { get; set; }
        [Column("INCL-EXCL")]
        public string INCL_EXCL { get; set; }
        [Column("MATERIAL-CLASS")]
        public string MATERIAL_CLASS { get; set; }
        [Column("FA-AC-TYPE")]
        public string FA_AC_TYPE { get; set; }
        [Column("MEASURE-UNIT")]
        public string MEASURE_UNIT { get; set; }
        [Column("REPAIRABLE")]
        public string REPAIRABLE { get; set; }
        [Column("MAT-TYPE")]
        public string MAT_TYPE { get; set; }
        [Column("DIM-TYPE")]
        public string DIM_TYPE { get; set; }
        [Column("INTERVAL DIMENSION")]
        public string IntervalDimension { get; set; }
        [Column("INTERVAL AMOUNT")]
        public string IntervalAmount { get; set; }
        [Column("UNLIMITED")]
        public string UNLIMITED { get; set; }
        [Column("TERMINATING")]
        public string TERMINATING { get; set; }
        [Column("LAST-REQ-TSN")]
        public string LAST_REQ_TSN { get; set; }
        [Column("LAST-REQ-CYCLES")]
        public string LAST_REQ_CYCLES { get; set; }
        [Column("LAST-REQ-DATE")]
        public string LAST_REQ_DATE { get; set; }
        [Column("NEXT DUE FH")]
        public string NEXT_DUE_FH { get; set; }
        [Column("NEXT DUE FC")]
        public string NEXT_DUE_FC { get; set; }
        [Column("NEXT DUE DATE ")]
        public string NEXT_DUE_DATE { get; set; }
        [AmosRequired]
        [Column("CONDITION")]
        public string CONDITION { get; set; }
        [Column("DELIVERY DATE")]
        public string DELIVERY_DATE { get; set; }
        [Column("MFG-DATE")]
        public string MFG_DATE { get; set; }
        [Column("INSTALLATION-DATE")]
        public string INSTALLATION_DATE { get; set; }
        [Column("TAH-INST")]
        public string TAH_INST { get; set; }
        [Column("TAC-INST")]
        public string TAC_INST { get; set; }
        [Column("TSN")]
        public string TSN { get; set; }
        [Column("CSN")]
        public string CSN { get; set; }
        [Column("TAH-CURRENT")]
        public string TAH_CURRENT { get; set; }
        [Column("TAC-CURRENT")]
        public string TAC_CURRENT { get; set; }
        [Column("TSN CURRENT")]
        public string TSN_CURRENT { get; set; }
        [Column("CSN CURRENT")]
        public string CSN_CURRENT { get; set; }
        [Column("OLD-LABELNO")]
        public string OLD_LABELNO { get; set; }
    }
}
