using ExcelToFlatFileFramework.Domain.Attributes;
using ExcelToFlatFileFramework.Domain.Enums;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _149_XPARTREQPE {
        [AmosOutputLength(38)]
        public string PARTREQ_TITLE { get; set; } // [38][m]
        [AmosOutputLength(2)]
        public string PARTREQ_TYPE { get; set; } // [2][m]
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; } // [70][m]
        [AmosOutputLength(32)]
        public string PARTNO { get; set; } // [32][m]
        [AmosOutputLength(20)]
        public string SERIALNO { get; set; } // [20][m]
        [AmosOutputLength(2)]
        public string DIMENSION { get; set; } // [2][m]
        [AmosOutputLength(10)]
        public string DUE_AMOUNT { get; set; } // [10][m]
        [AmosOutputLength(36)]
        public string EVENT_IDENTIFIER { get; set; } // [36]
    }
}