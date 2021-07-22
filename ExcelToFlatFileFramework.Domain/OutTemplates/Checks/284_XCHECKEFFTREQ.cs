using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _284_XCHECKEFFTREQ
    {
        [AmosOutputLength(20)]
        public string CheckType { get; set; }
        [AmosOutputLength(22)]
        public string InternalCheck { get; set; }
        [AmosOutputLength(70)]
        public string EffTitle { get; set; }
        [AmosOutputLength(1)]
        public string DimType { get; set; }
        [AmosOutputLength(1)]
        public string Fl { get; set; }
        [AmosOutputLength(2)]
        public string Dim { get; set; }
        [AmosOutputLength(10)]
        public string Amount { get; set; }
        [AmosOutputLength(1)]
        public string ThrBase { get; set; }
        [AmosOutputLength(2)]
        public string ThrBaseDim { get; set; }
        [AmosOutputLength(10)]
        public string ThrBaseAmount { get; set; }
        [AmosOutputLength(1)]
        public string Unlimited { get; set; }
        [AmosOutputLength(1)]
        public string Terminating { get; set; }
        [AmosOutputLength(4)]
        public string CalcStrat { get; set; }
        [AmosOutputLength(1)]
        public string AutoRepBack { get; set; }
    }
}
