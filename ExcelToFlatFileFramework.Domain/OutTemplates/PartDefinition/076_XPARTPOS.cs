using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition
{
    public class _076_XPARTPOS
    {
        public string NOTE { get; set; }
        public string PARTNO { get; set; } //[32][m]
        public string AC_TYPE { get; set; } //[6][m]
        public string POSITION { get; set; } //[14][m]
        public string ATA_CHAPTER { get; set; } //[12][m]
    }
}
