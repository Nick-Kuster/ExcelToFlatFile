using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartReq
{
    public class _134_XPARTREQ
    {
        public string PARTREQ_TITLE { get; set; } //[38][m]
        public string PARTREQ_TYPE { get; set; } //[2][m]
        public string DESCRIPTION { get; set; } //[36]
        public string REMOVAL_REQ { get; set; } //[1]
        public string SHELF_PERF { get; set; } //[1]
        public string HARD_SOFT { get; set; } //[4]
        public string PRO_RATA { get; set; } //[1]
        public string RATING { get; set; } //CAT[10]
    }
}
