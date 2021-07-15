using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class XDSOFF
    {
        public string DOCNO_1 { get; set; } //[30][m]
        public string DOC_TYPE_1 { get; set; } //[6][m]
        public string REVISION_1 { get; set; } //[4][m]
        public string ISSUED_BY_1 { get; set; } //[12][m]
        public string DOCNO_2 { get; set; } //[30][m]
        public string DOC_TYPE_2 { get; set; } //[6][m]
        public string REVISION_2 { get; set; } //[4][m]
        public string ISSUED_BY_2 { get; set; } //[12][m]
    }
}
