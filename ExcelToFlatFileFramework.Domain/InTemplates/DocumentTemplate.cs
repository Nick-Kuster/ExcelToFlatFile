using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;
using Npoi.Mapper.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    [AmosAtLeastOneRequired("DUE_HOURS", "DUE_CYCLES", "DUE_DATE")]
    public class DocumentTemplate : ValidationBase
    {   
        [AmosOutputLength(30)]
        [AmosRequired]
        [Column("DOCNO")]
        public string DOCNO { get; set; }
        [AmosOutputLength(70)]
        [AmosRequired]
        [Column("EFF-TITLE")]
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(32)]
        [Column("PARTNO")] 
        public string PartNo { get; set; }
        [AmosOutputLength(20)]
        [Column("SERIALNUMBER")]
        public string SerialNumber { get; set; }
        [AmosOutputLength(6)]
        [Column("AC-REGISTR")]
        public string AC_REGISTR { get; set; }
        [AmosOutputLength(6)]
        [AmosRequired]
        [Column("DOC-TYPE")]
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]
        [AmosRequired]
        [Column("REVISION")]
        public string REVISION { get; set; }
        [AmosOutputLength(12)]
        [AmosRequired]
        [Column("ISSUED-BY")]
        public string ISSUED_BY { get; set; }
        [AmosRequired]
        [AmosOutputLength(1)]
        [Column("AC-OR-COMP")]
        public string AC_OR_COMP { get; set; }
        [AmosRequired]
        [AmosOutputLength(12)]
        [Column("ATA-CHAPTER")]
        public string ATA_CHAPTER { get; set; }
        [AmosRequired]
        [AmosOutputLength(70)]
        [Column("TEXT1")]
        public string TEXT1 { get; set; }
        [AmosOutputLength(70)]
        [Column("TEXT2")]
        public string TEXT2 { get; set; }
        [AmosOutputLength(10)]
        [Column("REV-DATE")]
        public string REV_DATE { get; set; }
        [AmosRequired]
        [AmosOutputLength(10)]
        [Column("ISSUE-DATE")]
        public string ISSUE_DATE { get; set; }
        [AmosRequired]
        [AmosOutputLength(1)]
        [Column("TIME-LIMIT")]
        public string TIME_LIMIT { get; set; }
        [AmosRequired]
        [AmosOutputLength(1)]
        [Column("REPETITIVE")]
        public string REPETITIVE { get; set; }
        [AmosOutputLength(10)]
        [Column("THRESHOLD-HOURS")]
        public string THRESHOLD_HOURS { get; set; }
        [AmosOutputLength(10)]
        [Column("THRESHOLD-CYCLES")]
        public string THRESHOLD_CYCLES { get; set; }
        [AmosOutputLength(10)]
        [Column("THRESHOLD-DAYS")]
        public string THRESHOLD_DAYS { get; set; }
        [AmosOutputLength(10)]
        [Column("THRESHOLD-MONTHS")]
        public string THRESHOLD_MONTHS { get; set; }
        [AmosOutputLength(10)]
        [Column("THRESHOLD-YEARS")]
        public string THRESHOLD_YEARS { get; set; }
        [AmosOutputLength(10)]
        [Column("INTERVAL-HOURS")]
        public string INTERVAL_HOURS { get; set; }
        [AmosOutputLength(10)]
        [Column("INTERVAL-CYCLES")]
        public string INTERVAL_CYCLES { get; set; }
        [AmosOutputLength(10)]
        [Column("INTERVAL-DAYS")]
        public string INTERVAL_DAYS { get; set; }
        [AmosOutputLength(10)]
        [Column("INTERVAL-MONTHS")]
        public string INTERVAL_MONTHS { get; set; }
        [AmosOutputLength(10)]
        [Column("INTERVAL-YEARS")]
        public string INTERVAL_YEARS { get; set; }
        [AmosOutputLength(1)]
        [Column("UNLIMITED")]
        public string UNLIMITED { get; set; }
        [AmosOutputLength(10)]
        [Column("EFFECTIVE-DATE")]
        public string EFFECTIVE_DATE { get; set; }
        [AmosOutputLength(6)]
        [Column("AC-TYPE")]
        public string AC_TYPE { get; set; }
        [AmosOutputLength(6)]
        [Column("AC-MODEL")]
        public string AC_MODEL { get; set; }
        [AmosOutputLength(6)]
        [Column("AC-SUB")]
        public string AC_SUB { get; set; }
        [AmosOutputLength(70)]
        [Column("TEXT")]
        public string TEXT { get; set; }
        [AmosRequired]
        [AmosOutputLength(10)]
        [Column("PERF-HOURS")]
        public string PERF_HOURS { get; set; }
        [AmosRequired]
        [AmosOutputLength(6)]
        [Column("PERF-CYCLES")]
        public string PERF_CYCLES { get; set; }
        [AmosRequired]
        [AmosOutputLength(10)]
        [Column("PERF-DATE")]
        public string PERF_DATE { get; set; }
        [AmosOutputLength(10)]
        [Column("DUE-HOURS")]
        public string DUE_HOURS { get; set; }
        [AmosOutputLength(10)]
        [Column("DUE-CYCLES")]
        public string DUE_CYCLES { get; set; }
        [AmosOutputLength(10)]
        [Column("DUE-DATE")]
        public string DUE_DATE { get; set; }
        [AmosOutputLength(1)]
        [Column("STATUS")]
        public string STATUS { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is DocumentTemplate))
                return false;
            DocumentTemplate other = (DocumentTemplate)obj;
            bool equals = DOCNO == other.DOCNO &&
                          EFF_TITLE == other.EFF_TITLE &&
                          PartNo == other.PartNo &&
                          SerialNumber == other.SerialNumber &&
                          AC_REGISTR == other.AC_REGISTR &&
                          DOC_TYPE == other.DOC_TYPE &&
                          REVISION == other.REVISION &&
                          ISSUED_BY == other.ISSUED_BY &&
                          AC_OR_COMP == other.AC_OR_COMP &&
                          ATA_CHAPTER == other.ATA_CHAPTER &&
                          TEXT1 == other.TEXT1 &&
                          TEXT2 == other.TEXT2 &&
                          REV_DATE == other.REV_DATE &&
                          ISSUE_DATE == other.ISSUE_DATE &&
                          TIME_LIMIT == other.TIME_LIMIT &&
                          REPETITIVE == other.REPETITIVE &&
                          THRESHOLD_HOURS == other.THRESHOLD_HOURS &&
                          THRESHOLD_CYCLES == other.THRESHOLD_CYCLES &&
                          THRESHOLD_DAYS == other.THRESHOLD_DAYS &&
                          THRESHOLD_MONTHS == other.THRESHOLD_MONTHS &&
                          THRESHOLD_YEARS == other.THRESHOLD_YEARS &&
                          INTERVAL_HOURS == other.INTERVAL_HOURS &&
                          INTERVAL_CYCLES == other.INTERVAL_CYCLES &&
                          INTERVAL_DAYS == other.INTERVAL_DAYS &&
                          INTERVAL_MONTHS == other.INTERVAL_MONTHS &&
                          INTERVAL_YEARS == other.INTERVAL_YEARS &&
                          UNLIMITED == other.UNLIMITED &&
                          EFFECTIVE_DATE == other.EFFECTIVE_DATE &&
                          AC_TYPE == other.AC_TYPE &&
                          AC_MODEL == other.AC_MODEL &&
                          AC_SUB == other.AC_SUB &&
                          TEXT == other.TEXT &&
                          PERF_HOURS == other.PERF_HOURS &&
                          PERF_CYCLES == other.PERF_CYCLES &&
                          PERF_DATE == other.PERF_DATE &&
                          DUE_HOURS == other.DUE_HOURS &&
                          DUE_CYCLES == other.DUE_CYCLES &&
                          DUE_DATE == other.DUE_DATE &&
                          STATUS == other.STATUS;
            return equals;
        }
        
        public override int GetHashCode()
        {
            List<object> props = new List<object>()
            {
                DOCNO, EFF_TITLE, PartNo, SerialNumber, AC_REGISTR, DOC_TYPE, REVISION, ISSUED_BY, AC_OR_COMP, ATA_CHAPTER, TEXT1, TEXT2, REV_DATE, ISSUE_DATE, TIME_LIMIT, REPETITIVE, THRESHOLD_HOURS, THRESHOLD_CYCLES, THRESHOLD_DAYS, THRESHOLD_MONTHS, THRESHOLD_YEARS, INTERVAL_HOURS, INTERVAL_CYCLES, INTERVAL_DAYS, INTERVAL_MONTHS, INTERVAL_YEARS, UNLIMITED, EFFECTIVE_DATE, AC_TYPE, AC_MODEL, AC_SUB, TEXT, PERF_HOURS, PERF_CYCLES, PERF_DATE, DUE_HOURS, DUE_CYCLES, DUE_DATE, STATUS
            };
            return String.Join("|", props).GetHashCode();
        }
    }
}
