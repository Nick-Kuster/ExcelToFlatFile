using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _268_XDHIST
    {
        public string NOTE { get; set; } //
        public string DOCNO { get; set; } //[25][m]
        public string DOC_TYPE { get; set; } //[6][m]
        public string REVISION { get; set; } //[4][m]
        public string ISSUED_BY { get; set; } //[12][m]
        public string EFF_TITLE { get; set; } //[70][m]
        public string AC_REGISTR { get; set; } //[6]
        public string PARTNO { get; set; } //[32]
        public string SERIALNUMBER { get; set; } //[20]
        public string PERF_HOURS { get; set; } //[10]
        public string PERF_CYCLES { get; set; } //[6]
        public string PERF_DATE { get; set; } //[10]
        public string DIM_1 { get; set; } //[2]
        public string DUE_AMOUNT_1 { get; set; } //[10]
        public string PERF_AMOUNT_1 { get; set; } //[10]
        public string DIM_2 { get; set; } //[2]
        public string DUE_AMOUNT_2 { get; set; } //[10]
        public string PERF_AMOUNT_2 { get; set; } //[10]
        public string DIM_3 { get; set; } //[2]
        public string DUE_AMOUNT_3 { get; set; } //[10]
        public string PERF_AMOUNT_3 { get; set; } //[10]
        public string PERF_STATUS { get; set; } //[1][m]
        public string PARTLY_PERF { get; set; } //[1][m]
        public string PERF_REFDOC { get; set; } //[25]
        public string PERF_CUSTOMER_WO { get; set; } //[20]
        public string UNIQUE_ROT_ID { get; set; } //[15]
        public string IS_LAST_HISTORY { get; set; } //[1]
        public string EVENT_IDENTIFIER { get; set; } //[36]
        public string PERF_TEXT { get; set; } //[2500]
    }
}
