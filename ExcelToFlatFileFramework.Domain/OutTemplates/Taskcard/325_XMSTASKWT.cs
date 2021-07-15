using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _325_XMSTASKWT
    {
        public string MS_NAME { get; set; } //[25][m]
        public string MS_ISSUE { get; set; } //[8][m]
        public string MS_REVISION { get; set; } //[8][m]
        public string TASKNUMBER { get; set; } //[38][m]
        public string OP_TASK { get; set; } //[1]
        public string TASK_REVISION { get; set; } //[8][m]
        public string REVISION { get; set; } //[4]
        public string ATA_CHAPTER { get; set; } //[12][m]
        public string EVENT_CLASS { get; set; } //[1]
        public string DEFECT_CLASS { get; set; } //[1]
        public string PRIO { get; set; } //[4]
        public string PROJECTNO { get; set; } //[14]
    }
}
