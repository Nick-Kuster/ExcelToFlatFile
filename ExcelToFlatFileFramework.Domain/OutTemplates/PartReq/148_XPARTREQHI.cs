using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;
using ExcelToFlatFileFramework.Domain.Enums;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _148_XPARTREQHI
    {
        [AmosOutputLength(38)]
        public string PARTREQ_TITLE { get; set; } //[38][m]
        [AmosOutputLength(2)]
        public string PARTREQ_TYPE { get; set; } //[2][m]
        [AmosOutputLength(70)]
        public string EFF_TITLE { get; set; } //[70][m]
        [AmosOutputLength(32)]
        public string PARTNO { get; set; } //[32][m]
        [AmosOutputLength(20)]
        public string SERIALNO { get; set; } //[20][m]
        [AmosOutputLength(10)]
        public string PERF_DATE { get; set; } //[10][m]
        [AmosOutputLength(2)]
        public string CONTROL_DIM { get; set; } //[2][m]
        [AmosOutputLength(10)]
        public string DUE_AMOUNT { get; set; } //[10][m]
        [AmosOutputLength(10)]
        public string PERF_AMOUNT { get; set; } //[10][m]
        [AmosOutputLength(200)]
        public string UNIQUE_ID { get; set; } //[200][m]
        [AmosOutputLength(36)]
        public string EVENT_IDENTIFIER { get; set; } //[36]
    }
}
