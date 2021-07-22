using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _240_XDHE
    {
        [AmosOutputLength(25)]        
        public string DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY { get; set; }
        [AmosOutputLength(1)]        
        public string AC_OR_COMP { get; set; }
        [AmosOutputLength(12)]        
        public string ATA_CHAPTER { get; set; }
        [AmosOutputLength(4)]        
        public string COMPLIANCE { get; set; }
        [AmosOutputLength(70)]        
        public string TEXT1 { get; set; }
        [AmosOutputLength(70)]        
        public string TEXT2 { get; set; }
        [AmosOutputLength(10)]        
        public string REV_DATE { get; set; }
        [AmosOutputLength(10)]        
        public string ISSUE_DATE { get; set; }
        [AmosOutputLength(10)]        
        public string REC_DATE { get; set; }
        [AmosOutputLength(1)]        
        public string TIME_LIMIT { get; set; }
        [AmosOutputLength(1)]        
        public string REPETITIVE { get; set; }
        [AmosOutputLength(6)]        
        public string EST_GROUDTIME { get; set; }
        [AmosOutputLength(10)]        
        public string EFFECTIVE_DATE { get; set; }
        [AmosOutputLength(1)]        
        public string OPS_AFFECTED { get; set; }
        [AmosOutputLength(1)]        
        public string SIM_AFFECTED { get; set; }
        [AmosOutputLength(1)]        
        public string REMOVAL_REQ { get; set; }
        [AmosOutputLength(1)]        
        public string SHOP_OR_LINE { get; set; }
        [AmosOutputLength(12)]        
        public string CONTROLLED_BY { get; set; }
        [AmosOutputLength(1)]        
        public string TYPE_OF_CHANGE { get; set; }
        [AmosOutputLength(1)]        
        public string WARRANTY_LABOUR { get; set; }
        [AmosOutputLength(1)]        
        public string WARRANTY_MAT { get; set; }
        [AmosOutputLength(6)]        
        public string EST_MH_DOC { get; set; }
        [AmosOutputLength(25)]        
        public string ORG_DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string ORG_DOC_TYPE { get; set; }
        [AmosOutputLength(14)]        
        public string LABOUR_COST { get; set; }
        [AmosOutputLength(14)]        
        public string MAT_COST { get; set; }
        [AmosOutputLength(1)]        
        public string MOD_CAMPAIGN { get; set; }
        [AmosOutputLength(1)]        
        public string MOD_ATTRITION { get; set; }
        [AmosOutputLength(8)]        
        public string COSTCENTER { get; set; }
        [AmosOutputLength(10)]        
        public string COST_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string RELEASE_STATE { get; set; }
        [AmosOutputLength(1)]        
        public string INSPECTION { get; set; }
        [AmosOutputLength(8)]        
        public string ASSESS_RESP { get; set; }
        [AmosOutputLength(10)]        
        public string ASSESS_START { get; set; }
        [AmosOutputLength(10)]        
        public string ASSESS_END { get; set; }
        [AmosOutputLength(1)]        
        public string GRND_OPS_AFF { get; set; }
        [AmosOutputLength(1)]        
        public string TRIAL_INST { get; set; }
        [AmosOutputLength(1)]        
        public string OCCASION { get; set; }
        [AmosOutputLength(36)]        
        public string UUID { get; set; }
        [AmosOutputLength(100)]
        public string IMP_NOTES { get; set; }
    }
}
