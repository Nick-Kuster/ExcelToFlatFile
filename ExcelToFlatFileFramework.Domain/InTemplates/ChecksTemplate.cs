using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class ChecksTemplate : ValidationBase
    {
        [Column("CHECK-TYPE")]
        [AmosRequired]
        public string CHECK_TYPE { get; set; }
        [Column("EFF-TITLE")]
        [AmosRequired]
        public string EFF_TITLE { get; set; }
        [Column("AIRCRAFT")]
        [AmosRequired]
        public string Aircraft { get; set; }
        [Column("AIRCRAFT TAIL NUMBER")]
        public string AIRCRAFT_TAIL_NUMBER { get; set; }
        [Column("PERF-TAH")]
        [AmosRequired]
        public string PERF_TAH { get; set; }
        [Column("PERF-TAC")]
        [AmosRequired]
        public string PERF_TAC { get; set; }
        [Column("PERF-DATE")]
        [AmosRequired]
        public string PERF_DATE { get; set; }
        [Column("NEVER-PERFORMED")]
        [AmosRequired]
        public string NEVER_PERFORMED { get; set; }
    
        public override bool Equals(object obj)
        {
            if (!(obj is ChecksTemplate))
                return false;
            ChecksTemplate other = (ChecksTemplate)obj;
            
            var equals = CHECK_TYPE == other.CHECK_TYPE &&
                         EFF_TITLE == other.EFF_TITLE &&
                         AIRCRAFT_TAIL_NUMBER == other.AIRCRAFT_TAIL_NUMBER &&
                         PERF_TAH == other.PERF_TAH &&
                         PERF_TAC == other.PERF_TAC &&
                         PERF_DATE == other.PERF_DATE &&
                         NEVER_PERFORMED == other.NEVER_PERFORMED;
            return equals;
        }
        
        public override int GetHashCode()
        {
            List<object> props = new List<object>()
            {
                CHECK_TYPE, EFF_TITLE, AIRCRAFT_TAIL_NUMBER, PERF_TAH, PERF_TAC, PERF_DATE, NEVER_PERFORMED
            };
            return String.Join("|", props).GetHashCode();
        }
    }
}
