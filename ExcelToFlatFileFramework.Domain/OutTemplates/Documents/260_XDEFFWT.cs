using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _260_XDEFFWT
    {
        public string DOCNO { get; set; } //[25][m]
        public string DOC_TYPE { get; set; } //[6][m]
        public string REVISION { get; set; } //[4][m]
        public string ISSUED_BY { get; set; } //[12][m]
        public string EFF_TITLE { get; set; } //[70][m]
        public string WT_REVISION { get; set; } //[4]
        public string ATA_CHAPTER { get; set; } //[12][m]
        public string EVENT_CLASS { get; set; } //[1]
        public string DEFECT_CLASS { get; set; } //[1]
        public string PRIO { get; set; } //[4]
        public string PROJECTNO { get; set; } //[14]
    }
}
