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
        [Column("DOCNO")]
        [AmosRequired]
        public string DOCNO { get; set; }
        [Column("EFF-TITLE")]
        [AmosRequired]
        public string EFF_TITLE { get; set; }
        [Column("PARTNO")] 
        public string PartNo { get; set; }
        [Column("SERIALNUMBER")]
        public string SerialNumber { get; set; }
        [Column("AC-REGISTR")]
        public string AC_REGISTR { get; set; }
        [Column("DOC-TYPE")]
        [AmosRequired]
        public string DOC_TYPE { get; set; }
        [Column("REVISION")]
        [AmosRequired]
        public string REVISION { get; set; }
        [Column("ISSUED-BY")]
        [AmosRequired]
        public string ISSUED_BY { get; set; }
        [Column("AC-OR-COMP")]
        [AmosRequired]
        public string AC_OR_COMP { get; set; }
        [Column("ATA-CHAPTER")]
        [AmosRequired]
        public string ATA_CHAPTER { get; set; }
        [Column("TEXT1")]
        [AmosRequired]
        public string TEXT1 { get; set; }
        [Column("TEXT2")]
        public string TEXT2 { get; set; }
        [Column("REV-DATE")]
        public string REV_DATE { get; set; }
        [Column("ISSUE-DATE")]
        [AmosRequired]
        public string ISSUE_DATE { get; set; }
        [Column("TIME-LIMIT")]
        [AmosRequired]
        public string TIME_LIMIT { get; set; }
        [Column("REPETITIVE")]
        [AmosRequired]
        public string REPETITIVE { get; set; }
        [Column("THRESHOLD-HOURS")]
        public string THRESHOLD_HOURS { get; set; }
        [Column("THRESHOLD-CYCLES")]
        public string THRESHOLD_CYCLES { get; set; }
        [Column("THRESHOLD-DAYS")]
        public string THRESHOLD_DAYS { get; set; }
        [Column("THRESHOLD-MONTHS")]
        public string THRESHOLD_MONTHS { get; set; }
        [Column("THRESHOLD-YEARS")]
        public string THRESHOLD_YEARS { get; set; }
        [Column("INTERVAL-HOURS")]
        public string INTERVAL_HOURS { get; set; }
        [Column("INTERVAL-CYCLES")]
        public string INTERVAL_CYCLES { get; set; }
        [Column("INTERVAL-DAYS")]
        public string INTERVAL_DAYS { get; set; }
        [Column("INTERVAL-MONTHS")]
        public string INTERVAL_MONTHS { get; set; }
        [Column("INTERVAL-YEARS")]
        public string INTERVAL_YEARS { get; set; }
        [Column("UNLIMITED")]
        public string UNLIMITED { get; set; }
        [Column("EFFECTIVE-DATE")]
        public string EFFECTIVE_DATE { get; set; }
        [Column("AC-TYPE")]
        public string AC_TYPE { get; set; }
        [Column("AC-MODEL")]
        public string AC_MODEL { get; set; }
        [Column("AC-SUB")]
        public string AC_SUB { get; set; }
        [Column("TEXT")]
        [AmosRequired]
        public string TEXT { get; set; }
        [Column("PERF-HOURS")]
        [AmosRequired]
        public string PERF_HOURS { get; set; }
        [Column("PERF-CYCLES")]
        [AmosRequired]
        public string PERF_CYCLES { get; set; }
        [Column("PERF-DATE")]
        [AmosRequired]
        public string PERF_DATE { get; set; }
        [Column("DUE-HOURS")]
        public string DUE_HOURS { get; set; }
        [Column("DUE-CYCLES")]
        public string DUE_CYCLES { get; set; }
        [Column("DUE-DATE")]
        public string DUE_DATE { get; set; }
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
