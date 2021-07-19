using System.Collections.Generic;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard
{
    public class TaskcardOutTemplate
    {
        public List<_350_XMSTASKHIST> _350Xmstaskhist { get; set; }
        public List<_351_XMSTASKPEND> _351_XMSTASKPEND { get; set; }
        public List<_352_XMSTASKPENDINT> _352_XMSTASKPENDINT { get; set; }
        public List<_354_XMSTASKPRESET> _354_XMSTASKPRESET { get; set; }
    }
}