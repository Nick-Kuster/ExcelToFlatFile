using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _119_XEFFSER
    {
        public string EFF_TITLE { get; set; } //[70][m]
        public string RANGE_TYPE { get; set; } //[1][m]
        public string SERIALNO_FROM { get; set; } //[20]
        public string SERIALNO_TO { get; set; } //[20]
        public string INCL_EXCL { get; set; } //[1][m]
        public string SER_SHIFT { get; set; } //[1]
    }
}
