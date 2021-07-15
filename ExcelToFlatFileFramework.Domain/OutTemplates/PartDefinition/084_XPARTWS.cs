using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _084_XPARTWS
    {
        public string PARTNO { get; set; } //[32][m]
        public string SEQ_NO { get; set; } //[4][m]
        public string WS_TYPE { get; set; } //[1]
        public string HEADER { get; set; } //[70]
        public string SIGN { get; set; } //[8]
        public string CRITICAL { get; set; } //[1]
        public string DEFUEL { get; set; } //[1]
        public string DOUBLE_INSP { get; set; } //[1]
        public string EL_POWER { get; set; } //[1]
        public string EVENT_OPEN { get; set; } //[1]
        public string EWIS { get; set; } //[1]
        public string EXT_HYDR { get; set; } //[1]
        public string HYRD_OFF { get; set; } //[1]
        public string IDLE_RUN { get; set; } //[1]
        public string INSURANCE { get; set; } //[1]
        public string NDT { get; set; } //[1]
        public string POWER_RUN { get; set; } //[1]
        public string TANK_ENTRY { get; set; } //[1]
        public string TEST_FLIGHT { get; set; } //[1]
        public string TROUBLESHOOTING { get; set; } //[1]
        public string WARRANTY { get; set; } //[1]
        public string ETOPS { get; set; } //[1]
        public string AD { get; set; } //[1]
        public string PHASE { get; set; } //[15]
        public string REVISION { get; set; } //[4]
        public string REV_STATUS { get; set; } //[1][m]
        public string TEXT { get; set; } //[1500][m]
        public string COMMENT { get; set; } //[1000]
    }
}
