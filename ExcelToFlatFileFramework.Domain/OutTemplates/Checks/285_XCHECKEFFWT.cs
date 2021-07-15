using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _285_XCHECKEFFWT
    {
        public string CHECK_TYPE { get; set; } //[20][m]
        public string INTERNAL_CHECK { get; set; } //[22]
        public string EFF_TITLE { get; set; } //[70][m]
        public string REVISION { get; set; } //[4]
        public string ATA_CHAPTER { get; set; } //[12][m]
        public string EVENT_CLASS { get; set; } //[1]
        public string DEFECT_CLASS { get; set; } //[1]
        public string PRIO { get; set; } //[4]
        public string PROJECTNO { get; set; } //[14]
    }
}
