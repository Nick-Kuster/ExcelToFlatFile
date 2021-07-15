using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _122_XROTABLE
    {
        public string PARTNO { get; set; } //[32][m]
        public string SERIALNO { get; set; } //[20][m]
        public string OWNER { get; set; } //[12][m]
        public string DEL_DATE { get; set; } //[10][m]
        public string MFG_DATE { get; set; } //[10]
        public string LABELNO { get; set; } //[8]
        public string AIRCRAFT { get; set; } //[6]
        public string POSITION { get; set; } //[14]
        public string STATION { get; set; } //[4]
        public string STORE { get; set; } //[8]
        public string LOCATION { get; set; } //[16]
        public string ENTITY { get; set; } //[12]
        public string READOUT_DATE { get; set; } //[10]
        public string TAH_INST { get; set; } //[10]
        public string TAC_INST { get; set; } //[6]
        public string TSN { get; set; } //[10]
        public string CSN { get; set; } //[6]
        public string CONDITION { get; set; } //[2][m]
        public string LAST_OH_DATE { get; set; } //[10]
        public string OH_DATE_UNK { get; set; } //[1]
        public string LAST_OH_CYCLES { get; set; } //[6]
        public string OH_CYCLES_UNK { get; set; } //[1]
        public string LAST_OH_TSN { get; set; } //[10]
        public string OH_TSN_UNK { get; set; } //[1]
        public string LAST_REP_DATE { get; set; } //[10]
        public string REP_DATE_UNK { get; set; } //[1]
        public string LAST_REP_CYCLES { get; set; } //[6]
        public string REP_CYCLES_UNK { get; set; } //[1]
        public string LAST_REP_TSN { get; set; } //[10]
        public string REP_TSN_UNK { get; set; } //[1]
        public string LAST_MOD_DATE { get; set; } //[10]
        public string MOD_DATE_UNK { get; set; } //[1]
        public string LAST_MOD_CYCLES { get; set; } //[6]
        public string MOD_CYCLES_UNK { get; set; } //[1]
        public string LAST_MOD_TSN { get; set; } //[10]
        public string MOD_TSN_UNK { get; set; } //[1]
        public string OLD_LABELNO { get; set; } //[40]
        public string TSN_UNKNOWN { get; set; } //[1]
        public string CSN_UNKNOWN { get; set; } //[1]
        public string MFG_UNKNOWN { get; set; } //[1]
    }
}
