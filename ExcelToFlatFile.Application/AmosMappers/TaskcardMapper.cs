using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class TaskcardMapper : BaseMapper<TaskcardTemplate, TaskcardOutTemplate>
    {
        public override TaskcardOutTemplate Map(List<TaskcardTemplate> input)
        {
            List<_350_XMSTASKHIST> xmstaskhist = new List<_350_XMSTASKHIST>();
            List<_351_XMSTASKPEND> xmstaskpends = new List<_351_XMSTASKPEND>();
            List<_352_XMSTASKPENDINT> xmstaskpendints = new List<_352_XMSTASKPENDINT>();
            List<_354_XMSTASKPRESET> xmstaskpresets = new List<_354_XMSTASKPRESET>();

            foreach (var row in input)
            {
                xmstaskhist.Add(GetXMsTaskHist(row));
                xmstaskpends.Add(GetXMsTaskPends(row));
                xmstaskpendints.Add(GetXMsTaskPendInts(row));
                xmstaskpresets.Add(GetXMsTaskPresets(row));
            }

            TaskcardOutTemplate outTemplate = new TaskcardOutTemplate
            {
                _350Xmstaskhist = xmstaskhist,
                _351_XMSTASKPEND = xmstaskpends,
                _352_XMSTASKPENDINT = xmstaskpendints,
                _354_XMSTASKPRESET = xmstaskpresets
            };

            return outTemplate;
        }
        private _350_XMSTASKHIST GetXMsTaskHist(TaskcardTemplate input)
        {
            // _350_XMSTASKHIST output = new _350_XMSTASKHIST() // None of this exists in template.
            // {
            //     MS_NAME = input.
            // }

            return new _350_XMSTASKHIST();
        }
        private _351_XMSTASKPEND GetXMsTaskPends(TaskcardTemplate input)
        {
            _351_XMSTASKPEND output = new _351_XMSTASKPEND()
            {
                TASKNUMBER = input.TASKNUMBER,
                AC_REGISTR = input.TASKNUMBER,
                TASKCARDNO = "",
                TASKCARD_ID = "",
                EVENT_IDENTIFIER = ""
            };
            return output;
        }
        private _352_XMSTASKPENDINT GetXMsTaskPendInts(TaskcardTemplate input)
        {
            _352_XMSTASKPENDINT output = new _352_XMSTASKPENDINT()
            {
                TASKNUMBER = input.TASKNUMBER,
                AC_REGISTR = input.TASKNUMBER,
                DIMENSION = "", // Do not have this in template
                AMOUNT_DUE = "",
                TASKCARDNO = "",
                TASKCARD_ID = ""
            };

            return output;
        }
        private _354_XMSTASKPRESET GetXMsTaskPresets(TaskcardTemplate input)
        {
            _354_XMSTASKPRESET output = new _354_XMSTASKPRESET()
            {
                TASKNUMBER = input.TASKNUMBER,
                AC_REGISTR = input.TASKNUMBER,
                DIMENSION = "", // Not in Template
                AMOUNT_DUE = "", // Dimension not in template
                DUE_DAY_TIME = "",
                CHANGED_DATE = "",
                CHANGED_TIME = "",
                REQ_LINK_HEADERNO_OP = "",
                TASKCARDNO = "",
                TASKCARD_ID = ""
            };
            return output;
        }

        

        

        
    }
}