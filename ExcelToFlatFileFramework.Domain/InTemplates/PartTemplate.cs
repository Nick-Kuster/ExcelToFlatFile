using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.InTemplates
{
    public class PartTemplate
    {
        public string Aircraft { get; set; }
        public string ATA { get; set; }
        public string PART_NUMBER { get; set; }
        public string SERIAL_NUMBER { get; set; }
        public string DESCRIPTION { get; set; }
        public string Position { get; set; }
        public string DOCUMENT_REF_NO { get; set; }
        public string Part_Req_Title { get; set; }
        public string Eff_Title { get; set; }
        public string Part_Req_Description { get; set; }
        public string REQUIREMENT { get; set; }
        public string Removal_Req { get; set; }
        public string RANGE_TYPE { get; set; }
        public string SERIALNO_FROM { get; set; }
        public string SERIALNO_TO { get; set; }
        public string INCL_EXCL { get; set; }
        public string MATERIAL_CLASS { get; set; }
        public string FA_AC_TYPE { get; set; }
        public string MEASURE_UNIT { get; set; }
        public string REPAIRABLE { get; set; }
        public string MAT_TYPE { get; set; }
        public string DIM_TYPE { get; set; }
        public string INTERVAL_FH { get; set; }
        public string INTERVAL_FC { get; set; }
        public string INTERVAL_DAY { get; set; }
        public string UNLIMITED { get; set; }
        public string TERMINATING { get; set; }
        public string LAST_REQ_TSN { get; set; }
        public string LAST_REQ_CYCLES { get; set; }
        public string LAST_REQ_DATE { get; set; }
        public string NEXT_DUE_FH { get; set; }
        public string NEXT_DUE_FC { get; set; }
        public string NEXT_DUE_DATE { get; set; }
        public string TO_GO_FH { get; set; }
        public string TO_GO_FC { get; set; }
        public string TO_GO_DAY { get; set; }
        public string CONDITION { get; set; }
        public string DELIVERY_DATE { get; set; }
        public string MFG_DATE { get; set; }
        public string INSTALLATION_DATE { get; set; }
        public string TAH_INST { get; set; }
        public string TAC_INST { get; set; }
        public string TSN { get; set; }
        public string CSN { get; set; }
        public string TAH_CURRENT { get; set; }
        public string TAC_CURRENT { get; set; }
        public string TSN_CURRENT { get; set; }
        public string CSN_CURRENT { get; set; }
        public string OLD_LABELNO { get; set; }
    }
}
