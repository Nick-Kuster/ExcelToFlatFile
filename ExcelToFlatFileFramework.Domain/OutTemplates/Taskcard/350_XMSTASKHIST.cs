using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _350_XMSTASKHIST
    {
        public string MS_NAME { get; set; } //[25][m]
        public string MS_ISSUE { get; set; } //[8][m]
        public string MS_REVISION { get; set; } //[8][m]
        public string TASKNUMBER { get; set; } //[38][m]
        public string OP_TASK { get; set; } //[1]
        public string TASK_REVISION { get; set; } //[8][m]
        public string TASKCARDNO { get; set; } //[50]
        public string TASKCARD_ID { get; set; } //[12]
        public string AC_REGISTR { get; set; } //[6][m]
        public string MECH_SIGN { get; set; } //[8][m]
        public string RELEASE_STATION { get; set; } //[4][m]
        public string RELEASE_TIME { get; set; } //[6]
        public string DUE_TAH { get; set; } //[10]
        public string PERF_TAH { get; set; } //[10]
        public string DUE_TAC { get; set; } //[6]
        public string PERF_TAC { get; set; } //[6]
        public string DUE_DATE { get; set; } //[10]
        public string PERF_DATE { get; set; } //[10]
        public string UNIQUE_ID { get; set; } //[200][m]
        public string EVENT_IDENTIFIER { get; set; } //[36]
        public string REMARKS { get; set; } //[1000]
    }
}
