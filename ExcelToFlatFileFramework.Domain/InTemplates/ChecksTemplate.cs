using System;
using System.Collections.Generic;
using Npoi.Mapper.Attributes;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class ChecksTemplate : ValidationBase
    {
        [AmosRequired]
        [AmosOutputLength(20)]
        [Column("CHECK-TYPE")]
        public string CheckType { get; set; }
        [AmosRequired]
        [AmosOutputLength(70)]
        [Column("EFF-TITLE")]
        public string EffTitle { get; set; }
        [AmosRequired]
        [AmosOutputLength(6)]
        [Column("AIRCRAFT")]
        public string Aircraft { get; set; }
        [Column("AIRCRAFT TAIL NUMBER")]
        [AmosOutputLength(20)]
        public string AircraftTailNumber { get; set; }
        [AmosRequired]
        [AmosOutputLength(20)]
        [Column("PERF-TAH")]
        public string PerfTah { get; set; }
        [AmosRequired]
        [AmosOutputLength(20)]
        [Column("PERF-TAC")]
        public string PerfTac { get; set; }
        [AmosRequired]
        [AmosOutputLength(20)]
        [Column("PERF-DATE")]
        public string PerfDate { get; set; }
        [AmosRequired]
        [AmosOutputLength(20)]
        [Column("NEVER-PERFORMED")]
        public string NeverPerformed { get; set; }
    
        public override bool Equals(object obj)
        {
            if (!(obj is ChecksTemplate))
                return false;
            ChecksTemplate other = (ChecksTemplate)obj;
            
            var equals = CheckType == other.CheckType &&
                         EffTitle == other.EffTitle &&
                         AircraftTailNumber == other.AircraftTailNumber &&
                         PerfTah == other.PerfTah &&
                         PerfTac == other.PerfTac &&
                         PerfDate == other.PerfDate &&
                         NeverPerformed == other.NeverPerformed;
            return equals;
        }
        
        public override int GetHashCode()
        {
            List<object> props = new List<object>()
            {
                CheckType, EffTitle, AircraftTailNumber, PerfTah, PerfTac, PerfDate, NeverPerformed
            };
            return String.Join("|", props).GetHashCode();
        }
    }
}
