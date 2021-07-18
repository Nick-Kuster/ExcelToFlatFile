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
    [AmosAtLeastOneRequired("LAST_REQ_TSN", "LAST_REQ_CYCLES", "LAST_REQ_DATE")]
    [AmosAtLeastOneRequired("NEXT_DUE_FH", "NEXT_DUE_FC", "NEXT_DUE_DATE")]
    [AmosAtLeastOneRequired("DELIVERY_DATE", "INSTALLATION_DATE")]
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

        public override bool Equals(object obj)
        {
            if (!(obj is PartTemplate))
                return false;
            PartTemplate other = (PartTemplate)obj;
            bool equal =
                other.Aircraft == Aircraft &&
                other.ATA == ATA &&
                other.PART_NUMBER == PART_NUMBER &&
                other.SERIAL_NUMBER == SERIAL_NUMBER &&
                other.DESCRIPTION == DESCRIPTION &&
                other.Position == Position &&
                other.TaskcardReference == TaskcardReference &&
                other.Part_Req_Title == Part_Req_Title &&
                other.Eff_Title == Eff_Title &&
                other.Part_Req_Description == Part_Req_Description &&
                other.REQUIREMENT == REQUIREMENT &&
                other.Removal_Req == Removal_Req &&
                other.RANGE_TYPE == RANGE_TYPE &&
                other.SERIALNO_FROM == SERIALNO_FROM &&
                other.SERIALNO_TO == SERIALNO_TO &&
                other.INCL_EXCL == INCL_EXCL &&
                other.MATERIAL_CLASS == MATERIAL_CLASS &&
                other.FA_AC_TYPE == FA_AC_TYPE &&
                other.MEASURE_UNIT == MEASURE_UNIT &&
                other.REPAIRABLE == REPAIRABLE &&
                other.MAT_TYPE == MAT_TYPE &&
                other.DIM_TYPE == DIM_TYPE &&
                other.IntervalDimension == IntervalDimension &&
                other.IntervalAmount == IntervalAmount &&
                other.UNLIMITED == UNLIMITED &&
                other.TERMINATING == TERMINATING &&
                other.LAST_REQ_TSN == LAST_REQ_TSN &&
                other.LAST_REQ_CYCLES == LAST_REQ_CYCLES &&
                other.LAST_REQ_DATE == LAST_REQ_DATE &&
                other.NEXT_DUE_FH == NEXT_DUE_FH &&
                other.NEXT_DUE_FC == NEXT_DUE_FC &&
                other.NEXT_DUE_DATE == NEXT_DUE_DATE &&
                other.CONDITION == CONDITION &&
                other.DELIVERY_DATE == DELIVERY_DATE &&
                other.MFG_DATE == MFG_DATE &&
                other.INSTALLATION_DATE == INSTALLATION_DATE &&
                other.TAH_INST == TAH_INST &&
                other.TAC_INST == TAC_INST &&
                other.TSN == TSN &&
                other.CSN == CSN &&
                other.TAH_CURRENT == TAH_CURRENT &&
                other.TAC_CURRENT == TAC_CURRENT &&
                other.TSN_CURRENT == TSN_CURRENT &&
                other.CSN_CURRENT == CSN_CURRENT &&
                other.OLD_LABELNO == OLD_LABELNO;
            return equal;
        }
        
        public override int GetHashCode()
        {
            List<object> props = new List<object>()
            {
                Aircraft, ATA, PART_NUMBER, SERIAL_NUMBER, DESCRIPTION, Position, TaskcardReference, Part_Req_Title,
                Eff_Title, Part_Req_Description, REQUIREMENT, Removal_Req, RANGE_TYPE, SERIALNO_FROM, SERIALNO_TO,
                INCL_EXCL, MATERIAL_CLASS, FA_AC_TYPE, MEASURE_UNIT, REPAIRABLE, MAT_TYPE, DIM_TYPE, IntervalDimension,
                IntervalAmount, UNLIMITED, TERMINATING, LAST_REQ_TSN, LAST_REQ_CYCLES, LAST_REQ_DATE, NEXT_DUE_FH,
                NEXT_DUE_FC, NEXT_DUE_DATE, CONDITION, DELIVERY_DATE, MFG_DATE, INSTALLATION_DATE, TAH_INST, TAC_INST,
                TSN, CSN, TAH_CURRENT, TAC_CURRENT, TSN_CURRENT, CSN_CURRENT, OLD_LABELNO
            };
            return String.Join("|", props).GetHashCode();
        }
    }
}
