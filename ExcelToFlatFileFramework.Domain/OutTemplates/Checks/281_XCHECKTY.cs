using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _281_XCHECKTY
    {
        public string CHECK_TYPE { get; set; } //[20][m]
        public string DESCRIPTION { get; set; } //[36][m]
        public string DEFAULT_STATION { get; set; } //[4]
        public string NBR_OF_INTERNAL_CHECKS { get; set; } //[2][m]
        public string HAS_LIMIT { get; set; } //[1]
        public string LETTERCHECK { get; set; } //[1]
        public string COMPLIANCE { get; set; } //[4][m]
        public string CATEGORY { get; set; } //[1]

    }
}
