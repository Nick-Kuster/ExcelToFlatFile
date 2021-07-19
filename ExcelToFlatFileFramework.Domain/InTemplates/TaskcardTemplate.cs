using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class TaskcardTemplate : ValidationBase
    {
        [Column("TASKNUMBER")]
        [AmosRequired]
        public string TASKNUMBER { get; set; }
        [Column("EFF-TITLE")]
        [AmosRequired]
        public string EFF_TITLE { get; set; }
        [Column("AC-TYPE")]
        public string AC_TYPE { get; set; }
        [Column("AC-MODEL")]
        public string AC_MODEL { get; set; }
        [Column("AC-SUB")]
        public string AC_SUB { get; set; }
        [Column("AC-REGISTR")]
        [AmosRequired]
        public string AC_REGISTR { get; set; }
        [Column("PERFORMED DATE")]
        public string PERFORMED_DATE { get; set; }
        [Column("PERFORMED HOURS")]
        public string PERFORMED_HOURS { get; set; }
        [Column("PERFORMED CYCLES")]
        public string PERFORMED_CYCLES { get; set; }
        [Column("DUE DATE")]
        public string DUE_DATE { get; set; }
        [Column("DUE HOURS")]
        public string DUE_HOURS { get; set; }
        [Column("DUE CYCLES")]
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
