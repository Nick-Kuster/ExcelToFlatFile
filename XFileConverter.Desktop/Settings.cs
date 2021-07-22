using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFileConverter.Desktop
{
    public class Settings
    {
        public string CheckTemplate { get; set; }
        public string DocumentTemplate { get; set; }
        public string PartsTemplate { get; set; }
        public string TaskcardTemplate { get; set; }
        public string XfileOutputDir { get; set; }
        public string ErrorFileDir { get; set; }
    }
}
