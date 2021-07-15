using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _321_XMSTASKIV
    {
        public string MS_NAME { get; set; } //[25][m]
        public string MS_ISSUE { get; set; } //[8][m]
        public string MS_REVISION { get; set; } //[8][m]
        public string TASKNUMBER { get; set; } //[38][m]
        public string OP_TASK { get; set; } //[1]
        public string TASK_REVISION { get; set; } //[8][m]
        public string TYPE { get; set; } //[2][m]
        public string DIM_TYPE { get; set; } //[2]
        public string THR_BASE { get; set; } //[1]
        public string DIM_GROUP { get; set; } //[20]
        public string DIMENSION { get; set; } //[2]
        public string AMOUNT { get; set; } //[10]
        public string THR_BASE_DIM { get; set; } //[2]
        public string THR_BASE_AMOUNT { get; set; } //[10]
        public string UNLIMITED { get; set; } //[1]
        public string TERMINATING { get; set; } //[1]
        public string CALC_LOGIC { get; set; } //[1]
        public string CALC_STRAT { get; set; } //[4]
        public string AUTO_REP_BACK { get; set; } //[1]
        public string NOTES { get; set; } //[70]
    }
}
