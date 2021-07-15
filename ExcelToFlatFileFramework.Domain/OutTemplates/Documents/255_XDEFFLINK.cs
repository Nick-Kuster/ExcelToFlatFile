using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _255_XDEFFLINK
    {
        public string DOCNO { get; set; } //[25][m]
        public string DOC_TYPE { get; set; } //[6][m]
        public string REVISION { get; set; } //[4][m]
        public string ISSUED_BY { get; set; } //[12][m]
        public string EFF_TITLE { get; set; } //[70][m]
        public string AUTO_STATUS { get; set; } //[1]
        public string NEXT_SHOPVIS { get; set; } //[1]
        public string PRINT_REL0CERT { get; set; } //[1]
    }
}
