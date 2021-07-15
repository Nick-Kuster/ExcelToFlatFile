using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class _309_XMSTASKRV
    {
        public string MS_NAME { get; set; } //[25][m]
        public string MS_ISSUE { get; set; } //[8][m]
        public string MS_REVISION { get; set; } //[8][m]
        public string TASKNUMBER { get; set; } //[38][m]
        public string OP_TASK { get; set; } //[1]
        public string TITLE { get; set; } //[250][m]
        public string TASK_REVISION { get; set; } //[8][m]
        public string TASK_REVISION_DATE { get; set; } //[10][m]
        public string TASK_REVISION_REASON { get; set; } //[255][m]
        public string RELEASE_DATE { get; set; } //[10][m]
        public string COMPLIANCE { get; set; } //[4][m]
        public string STATUS { get; set; } //[1][m]
        public string TASK_TYPE { get; set; } //[1][m]
        public string INTERVAL_TYPE { get; set; } //[1][m]
        public string MAXRECURRENCE { get; set; } //[6]
        public string NOT { get; set; } //APPLICABLE[1]
        public string MRB_REVISION { get; set; } //[8]
        public string MRB_REVISION_DATE { get; set; } //[10]
        public string MRB_REVISION_REASON { get; set; } //[255]
        public string EST_MH_MRB { get; set; } //[6]
        public string REQ_MAND_REP { get; set; } //[1]
        public string CRX_REV_FLAG { get; set; } //[2]
        public string CP_SEQ { get; set; } //[10]
        public string STATE { get; set; } //[1]
        public string EFF_NOTES { get; set; } //[500]
        public string NOTES { get; set; } //[1000]
        public string MRB_TEXT { get; set; } //[1500]
        public string REMARKS { get; set; } //[3000]
    }
}
