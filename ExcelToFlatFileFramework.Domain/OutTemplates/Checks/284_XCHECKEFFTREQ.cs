using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _284_XCHECKEFFTREQ
    {
        public string CHECK_TYPE { get; set; } //[20][m]
        public string INTERNAL_CHECK { get; set; } //[22]
        public string EFF_TITLE { get; set; } //[70][m]
        public string DIM_TYPE { get; set; } //[1]
        public string FL { get; set; } //[1]
        public string DIM { get; set; } //[2]
        public string AMOUNT { get; set; } //[10]
        public string THR_BASE { get; set; } //[1]
        public string THR_BASE_DIM { get; set; } //[2]
        public string THR_BASE_AMOUNT { get; set; } //[10]
        public string UNLIMITED { get; set; } //[1][m]
        public string TERMINATING { get; set; } //[1]
        public string CALC_STRAT { get; set; } //[4]
        public string AUTO_REP_BACK { get; set; } //[1]
    }
}
