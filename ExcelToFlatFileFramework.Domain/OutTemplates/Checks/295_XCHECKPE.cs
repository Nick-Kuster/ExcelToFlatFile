using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _295_XCHECKPE
    {
        public string CHECK_TYPE { get; set; } //[20][m]
        public string INTERNAL_CHECK { get; set; } //[22]
        public string EFF_TITLE { get; set; } //[70][m]
        public string AIRCRAFT { get; set; } //[6][m]
        public string NEVER_PERFORMED { get; set; } //[1][m]
        public string CONTROL_DIM_1 { get; set; } //[2][m]
        public string DUE_AMOUNT_1 { get; set; } //[10][m]
        public string CONTROL_DIM_2 { get; set; } //[2]
        public string DUE_AMOUNT_2 { get; set; } //[10]
        public string CONTROL_DIM_3 { get; set; } //[2]
        public string DUE_AMOUNT_3 { get; set; } //[10]
        public string EVENT_IDENTIFIER { get; set; } //[36]
    }
}
