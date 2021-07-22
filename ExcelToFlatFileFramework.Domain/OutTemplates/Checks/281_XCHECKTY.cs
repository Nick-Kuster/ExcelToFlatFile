using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _281_XCHECKTY
    {
        [AmosOutputLength(20)]
        public string CHECK_TYPE { get; set; }
        [AmosOutputLength(36)]
        public string DESCRIPTION { get; set; }
        [AmosOutputLength(4)]
        public string DEFAULT_STATION { get; set; }
        [AmosOutputLength(2)]
        public string NBR_OF_INTERNAL_CHECKS { get; set; }
        [AmosOutputLength(1)]
        public string HAS_LIMIT { get; set; }
        [AmosOutputLength(1)]
        public string LETTERCHECK { get; set; }
        [AmosOutputLength(4)]
        public string COMPLIANCE { get; set; }
        [AmosOutputLength(1)]
        public string CATEGORY { get; set; }

    }
}
