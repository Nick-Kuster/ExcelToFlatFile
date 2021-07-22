using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _285_XCHECKEFFWT
    {
        [AmosOutputLength(20)]
        public string CHECK_TYPE { get; set; }
        [AmosOutputLength(22)]
        public string INTERNAL_CHECK { get; set; }
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(4)]
        public string REVISION { get; set; }
        [AmosOutputLength(12)]
        public string ATA_CHAPTER { get; set; }
        [AmosOutputLength(1)]
        public string EVENT_CLASS { get; set; }
        [AmosOutputLength(1)]
        public string DEFECT_CLASS { get; set; }
        [AmosOutputLength(4)]
        public string PRIO { get; set; }
        [AmosOutputLength(14)]
        public string PROJECTNO { get; set; }
    }
}
