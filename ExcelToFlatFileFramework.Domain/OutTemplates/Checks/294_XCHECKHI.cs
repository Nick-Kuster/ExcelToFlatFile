using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Checks
{
    public class _294_XCHECKHI
    {
        [AmosOutputLength(20)]
        public string CheckType { get; set; }
        [AmosOutputLength(22)]
        public string InternalCheck { get; set; }
        [AmosOutputLength(70)]
        public string EffTitle { get; set; }
        [AmosOutputLength(6)]
        public string Aircraft { get; set; }
        [AmosOutputLength(10)]
        public string PerfTah { get; set; }
        [AmosOutputLength(6)]
        public string PerfTac { get; set; }
        [AmosOutputLength(10)]
        public string PerfDate { get; set; }
        [AmosOutputLength(2)]
        public string ControlDim1 { get; set; }
        [AmosOutputLength(10)]
        public string DueAmount1 { get; set; }
        [AmosOutputLength(10)]
        public string PerfAmount1 { get; set; }
        [AmosOutputLength(2)]
        public string ControlDim2 { get; set; }
        [AmosOutputLength(10)]
        public string DueAmount2 { get; set; }
        [AmosOutputLength(10)]
        public string PerfAmount2 { get; set; }
        [AmosOutputLength(2)]
        public string ControlDim3 { get; set; }
        [AmosOutputLength(10)]
        public string DueAmount3 { get; set; }
        [AmosOutputLength(10)]
        public string PerfAmount3 { get; set; }
        [AmosOutputLength(20)]
        public string PerfCustomerWo { get; set; }
        [AmosOutputLength(36)]
        public string EventIdentifier { get; set; }
    }
}
