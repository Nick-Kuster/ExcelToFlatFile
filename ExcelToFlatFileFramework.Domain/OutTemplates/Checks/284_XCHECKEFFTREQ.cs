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
        public string CHECK_TYPE { get; set; }
        [AmosOutputLength(22)]
        public string INTERNAL_CHECK { get; set; }
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(1)]
        public string DIM_TYPE { get; set; }
        [AmosOutputLength(1)]
        public string FL { get; set; }
        [AmosOutputLength(2)]
        public string DIM { get; set; }
        [AmosOutputLength(10)]
        public string AMOUNT { get; set; }
        [AmosOutputLength(1)]
        public string THR_BASE { get; set; }
        [AmosOutputLength(2)]
        public string THR_BASE_DIM { get; set; }
        [AmosOutputLength(10)]
        public string THR_BASE_AMOUNT { get; set; }
        [AmosOutputLength(1)]
        public string UNLIMITED { get; set; }
        [AmosOutputLength(1)]
        public string TERMINATING { get; set; }
        [AmosOutputLength(4)]
        public string CALC_STRAT { get; set; }
        [AmosOutputLength(1)]
        public string AUTO_REP_BACK { get; set; }
    }
}
