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
        public string DocNo { get; set; }
        [AmosOutputLength(6)]        
        public string DocType { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy { get; set; }
        [AmosOutputLength(1)]        
        public string AcOrComp { get; set; }
        [AmosOutputLength(12)]        
        public string AtaChapter { get; set; }
        [AmosOutputLength(4)]        
        public string Compliance { get; set; }
        [AmosOutputLength(70)]        
        public string Text1 { get; set; }
        [AmosOutputLength(70)]        
        public string Text2 { get; set; }
        [AmosOutputLength(10)]        
        public string RevDate { get; set; }
        [AmosOutputLength(10)]        
        public string IssueDate { get; set; }
        [AmosOutputLength(10)]        
        public string RecDate { get; set; }
        [AmosOutputLength(1)]        
        public string TimeLimit { get; set; }
        [AmosOutputLength(1)]        
        public string Repetitive { get; set; }
        [AmosOutputLength(6)]        
        public string EstGroundTime { get; set; }
        [AmosOutputLength(10)]        
        public string EffectiveDate { get; set; }
        [AmosOutputLength(1)]        
        public string OpsAffected { get; set; }
        [AmosOutputLength(1)]        
        public string SimAffected { get; set; }
        [AmosOutputLength(1)]        
        public string RemovalReq { get; set; }
        [AmosOutputLength(1)]        
        public string ShopOrLine { get; set; }
        [AmosOutputLength(12)]        
        public string ControlledBy { get; set; }
        [AmosOutputLength(1)]        
        public string TypeOfChange { get; set; }
        [AmosOutputLength(1)]        
        public string WarrantyLabour { get; set; }
        [AmosOutputLength(1)]        
        public string WarrantyMat { get; set; }
        [AmosOutputLength(6)]        
        public string EstMhDoc { get; set; }
        [AmosOutputLength(25)]        
        public string OrgDocNo { get; set; }
        [AmosOutputLength(6)]        
        public string OrgDocType { get; set; }
        [AmosOutputLength(14)]        
        public string LabourCost { get; set; }
        [AmosOutputLength(14)]        
        public string MatCost { get; set; }
        [AmosOutputLength(1)]        
        public string ModCampaign { get; set; }
        [AmosOutputLength(1)]        
        public string ModAttrition { get; set; }
        [AmosOutputLength(8)]        
        public string CostCenter { get; set; }
        [AmosOutputLength(10)]        
        public string CostType { get; set; }
        [AmosOutputLength(1)]        
        public string ReleaseState { get; set; }
        [AmosOutputLength(1)]        
        public string Inspection { get; set; }
        [AmosOutputLength(8)]        
        public string AssessResp { get; set; }
        [AmosOutputLength(10)]        
        public string AssessStart { get; set; }
        [AmosOutputLength(10)]        
        public string AssessEnd { get; set; }
        [AmosOutputLength(1)]        
        public string GrndOpsAff { get; set; }
        [AmosOutputLength(1)]        
        public string TrialInst { get; set; }
        [AmosOutputLength(1)]        
        public string Occasion { get; set; }
        [AmosOutputLength(36)]        
        public string Uuid { get; set; }
        [AmosOutputLength(100)]
        public string ImpNotes { get; set; }
    }
}
