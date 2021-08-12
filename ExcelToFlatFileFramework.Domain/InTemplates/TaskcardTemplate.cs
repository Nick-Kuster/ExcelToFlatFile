using System;
using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.Attributes;
using Npoi.Mapper.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    [AmosAtLeastOneRequired("PERFORMED_DATE", "PERFORMED_HOURS", "PERFORMED_CYCLES")]
    [AmosAtLeastOneRequired("DUE_DATE", "DUE_HOURS", "DUE_CYCLES")]
    public class TaskcardTemplate : ValidationBase
    {
        [Column("TASKNUMBER")]
        [AmosRequired]
        [AmosOutputLength(38)]
        public string TASKNUMBER { get; set; }
        [Column("EFF-TITLE")]
        [AmosRequired]
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; }
        [Column("AC-TYPE")]
        [AmosOutputLength(6)]
        public string AC_TYPE { get; set; }
        [Column("AC-MODEL")]
        [AmosOutputLength(6)]
        public string AC_MODEL { get; set; }
        [Column("AC-SUB")]
        [AmosOutputLength(6)]
        public string AC_SUB { get; set; }
        [Column("AC-REGISTR")] // This Column is required, but the value always defaults to the user-defined value.
        [AmosOutputLength(6)]
        public string AC_REGISTR { get; set; }
        [Column("PERFORMED DATE")]
        [AmosOutputLength(10)]
        public string PERFORMED_DATE { get; set; }
        [Column("PERFORMED HOURS")]
        [AmosOutputLength(10)]
        public string PERFORMED_HOURS { get; set; }
        [Column("PERFORMED CYCLES")]
        [AmosOutputLength(6)]
        public string PERFORMED_CYCLES { get; set; }
        [Column("DUE DATE")]
        [AmosOutputLength(10)]
        public string DUE_DATE { get; set; }
        [Column("DUE HOURS")]
        [AmosOutputLength(10)]
        public string DUE_HOURS { get; set; }
        [Column("DUE CYCLES")]
        [AmosOutputLength(10)]
        public string DUE_CYCLES { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is TaskcardTemplate))
                return false;
            TaskcardTemplate other = (TaskcardTemplate)obj;
            var equals = TASKNUMBER == other.TASKNUMBER &&
                         EFF_TITLE == other.EFF_TITLE &&
                         AC_TYPE == other.AC_TYPE &&
                         AC_MODEL == other.AC_MODEL &&
                         AC_SUB == other.AC_SUB &&
                         AC_REGISTR == other.AC_REGISTR &&
                         PERFORMED_DATE == other.PERFORMED_DATE &&
                         PERFORMED_HOURS == other.PERFORMED_HOURS &&
                         PERFORMED_CYCLES == other.PERFORMED_CYCLES &&
                         DUE_DATE == other.DUE_DATE &&
                         DUE_HOURS == other.DUE_HOURS &&
                         DUE_CYCLES == other.DUE_CYCLES;
            return equals;
        }
        
        public override int GetHashCode()
        {
            List<object> props = new List<object>()
            {
                TASKNUMBER, EFF_TITLE, AC_TYPE, AC_MODEL, AC_SUB, AC_REGISTR, PERFORMED_DATE, PERFORMED_HOURS, PERFORMED_CYCLES, DUE_DATE, DUE_HOURS, DUE_CYCLES
            };
            return String.Join("|", props).GetHashCode();
        }
    }
}
