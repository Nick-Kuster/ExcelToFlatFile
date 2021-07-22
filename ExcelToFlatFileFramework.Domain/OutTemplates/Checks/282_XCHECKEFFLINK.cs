using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _282_XCHECKEFFLINK
    {
        [AmosOutputLength(20)]
        public string CHECK_TYPE { get; set; }
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; }
    }
}
