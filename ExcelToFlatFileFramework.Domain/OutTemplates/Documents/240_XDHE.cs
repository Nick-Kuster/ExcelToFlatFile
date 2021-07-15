using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _240_XDHE
    {
        public string DOCNO { get; set; } //[25][m]
        public string DOC_TYPE { get; set; } //[6][m]
        public string REVISION { get; set; } //[4][m]
        public string ISSUED_BY { get; set; } //[12][m]
        public string AC_OR_COMP { get; set; } //[1][m]
        public string ATA_CHAPTER { get; set; } //[12][m]
        public string COMPLIANCE { get; set; } //[4][m]
        public string TEXT1 { get; set; } //[70][m]
        public string TEXT2 { get; set; } //[70]
        public string REV_DATE { get; set; } //[10]
        public string ISSUE_DATE { get; set; } //[10][m]
        public string REC_DATE { get; set; } //[10]
        public string TIME_LIMIT { get; set; } //[1][m]
        public string REPETITIVE { get; set; } //[1][m]
        public string EST_GROUDTIME { get; set; } //[6]
        public string EFFECTIVE_DATE { get; set; } //[10]
        public string OPS_AFFECTED { get; set; } //[1]
        public string SIM_AFFECTED { get; set; } //[1]
        public string REMOVAL_REQ { get; set; } //[1]
        public string SHOP_OR_LINE { get; set; } //[1]
        public string CONTROLLED_BY { get; set; } //[12]
        public string TYPE_OF_CHANGE { get; set; } //[1]
        public string WARRANTY_LABOUR { get; set; } //[1]
        public string WARRANTY_MAT { get; set; } //[1]
        public string EST_MH_DOC { get; set; } //[6]
        public string ORG_DOCNO { get; set; } //[25]
        public string ORG_DOC_TYPE { get; set; } //[6]
        public string LABOUR_COST { get; set; } //[14]
        public string MAT_COST { get; set; } //[14]
        public string MOD_CAMPAIGN { get; set; } //[1]
        public string MOD_ATTRITION { get; set; } //[1]
        public string COSTCENTER { get; set; } //[8]
        public string COST_TYPE { get; set; } //[10]
        public string RELEASE_STATE { get; set; } //[1]
        public string INSPECTION { get; set; } //[1]
        public string ASSESS_RESP { get; set; } //[8]
        public string ASSESS_START { get; set; } //[10]
        public string ASSESS_END { get; set; } //[10]
        public string GRND_OPS_AFF { get; set; } //[1]
        public string TRIAL_INST { get; set; } //[1]
        public string OCCASION { get; set; } //[1]
        public string UUID { get; set; } //[36]
        public string IMP_NOTES { get; set; } //[100]
    }
}
