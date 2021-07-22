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
        public string CheckType { get; set; }
        [AmosOutputLength(22)]
        public string InternalCheck { get; set; }
        [AmosOutputLength(70)]
        public string EffTitle { get; set; }
        [AmosOutputLength(4)]
        public string Revision { get; set; }
        [AmosOutputLength(12)]
        public string AtaChapter { get; set; }
        [AmosOutputLength(1)]
        public string EventClass { get; set; }
        [AmosOutputLength(1)]
        public string DefectClass { get; set; }
        [AmosOutputLength(4)]
        public string Prio { get; set; }
        [AmosOutputLength(14)]
        public string ProjectNo { get; set; }
    }
}
