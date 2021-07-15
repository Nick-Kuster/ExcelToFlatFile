using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _354_XMSTASKPRESET
    {
        public string TASKNUMBER { get; set; } //[38][m]
        public string AC_REGISTR { get; set; } //[6][m]
        public string DIMENSION { get; set; } //[2][m]
        public string AMOUNT_DUE { get; set; } //[10][m]
        public string DUE_DAY_TIME { get; set; } //[4]
        public string CHANGED_DATE { get; set; } //[5]
        public string CHANGED_TIME { get; set; } //[4]
        public string REQ_LINK_HEADERNO_OP { get; set; } //[10]
        public string TASKCARDNO { get; set; } //[50]
        public string TASKCARD_ID { get; set; } //[12]
    }
}
