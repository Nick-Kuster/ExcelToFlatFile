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
        public string CheckType { get; set; }
        [AmosOutputLength(36)]
        public string Description { get; set; }
        [AmosOutputLength(4)]
        public string DefaultStation { get; set; }
        [AmosOutputLength(2)]
        public string NbrOfInternalChecks { get; set; }
        [AmosOutputLength(1)]
        public string HasLimit { get; set; }
        [AmosOutputLength(1)]
        public string LetterCheck { get; set; }
        [AmosOutputLength(4)]
        public string Compliance { get; set; }
        [AmosOutputLength(1)]
        public string Category { get; set; }

    }
}
