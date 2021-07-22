using System;
using System.Collections.Generic;
using Npoi.Mapper.Attributes;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class ChecksTemplate : ValidationBase
    {
        [AmosRequired]
        [Column("CHECK-TYPE")]
        public string CHECK_TYPE { get; set; }
        [AmosRequired]
        [Column("EFF-TITLE")]
        public string EFF_TITLE { get; set; }
        [AmosRequired]
        [Column("AIRCRAFT")]
        public string Aircraft { get; set; }
        [Column("AIRCRAFT TAIL NUMBER")]
        public string AIRCRAFT_TAIL_NUMBER { get; set; }
        [AmosRequired]
        [Column("PERF-TAH")]
        public string PERF_TAH { get; set; }
        [AmosRequired]
        [Column("PERF-TAC")]
        public string PERF_TAC { get; set; }
        [AmosRequired]
        [Column("PERF-DATE")]
        public string PERF_DATE { get; set; }
        [AmosRequired]
        [Column("NEVER-PERFORMED")]
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
