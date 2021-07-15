using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class TaskcardTemplate
    {
        public string TASKNUMBER { get; set; }
        public string EFF_TITLE { get; set; }
        public string AC_TYPE { get; set; }
        public string AC_MODEL { get; set; }
        public string AC_SUB { get; set; }
        public string AC_REGISTR { get; set; }
        public string PERFORMED_DATE { get; set; }
        public string PERFORMED_HOURS { get; set; }
        public string PERFORMED_CYCLES { get; set; }
        public string DUE_DATE { get; set; }
        public string DUE_HOURS { get; set; }
        public string DUE_CYCLES { get; set; }
    }
}
