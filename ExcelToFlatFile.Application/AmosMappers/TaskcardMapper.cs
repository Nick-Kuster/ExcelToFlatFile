using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard;
using NPOI.SS.Formula.Functions;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class TaskcardMapper : BaseMapper<TaskcardTemplate, TaskcardOutTemplate>
    {
        public override TaskcardOutTemplate Map(List<TaskcardTemplate> input)
        {
            // List<_118_XEFF> _118_XEFF = new List<_118_XEFF>();
            // List<_119_XEFFSER> _119_XEFFSER = new List<_119_XEFFSER>();
            // List<_308_XMSTASK> _308_XMSTASK = new List<_308_XMSTASK>();
            // List<_309_XMSTASKRV> _309_XMSTASKRV = new List<_309_XMSTASKRV>();
            // List<_318_XMSTASKMPD> _318_XMSTASKMPD = new List<_318_XMSTASKMPD>();
            // List<_321_XMSTASKIV> _321_XMSTASKIV = new List<_321_XMSTASKIV>();
            // List<_325_XMSTASKWT> _325_XMSTASKWT = new List<_325_XMSTASKWT>();
            // List<_330_XMSTSAKITWS> _330_XMSTSAKITWS = new List<_330_XMSTSAKITWS>();
            // List<_339_XMSTASKITEF> _339_XMSTASKITEF = new List<_339_XMSTASKITEF>();
            List<_350_XMSTASKHIST> xmstaskhist = new List<_350_XMSTASKHIST>();
            List<_351_XMSTASKPEND> xmstaskpends = new List<_351_XMSTASKPEND>();
            List<_352_XMSTASKPENDINT> xmstaskpendints = new List<_352_XMSTASKPENDINT>();
            List<_354_XMSTASKPRESET> xmstaskpresets = new List<_354_XMSTASKPRESET>();

            foreach (var row in input)
            {
                // _118_XEFF.Add(Get118_XEFF(row));
                // _119_XEFFSER.Add(Get119_XEFFSER(row));
                // _308_XMSTASK.Add(Get308_XMSTASK(row));
                // _309_XMSTASKRV.Add(Get309_XMSTASKRV(row));
                // _318_XMSTASKMPD.Add(Get318_XMSTASKMPD(row));
                // _321_XMSTASKIV.Add(Get321_XMSTASKIV(row));
                // _325_XMSTASKWT.Add(Get325_XMSTASKWT(row));
                // _330_XMSTSAKITWS.Add(Get330_XMSTSAKITWS(row));
                // _339_XMSTASKITEF.Add(Get339_XMSTASKITEF(row));
                xmstaskhist.Add(GetXMsTaskHist(row));
                xmstaskpends.Add(GetXMsTaskPends(row));
                xmstaskpendints.Add(GetXMsTaskPendInts(row));
                xmstaskpresets.Add(GetXMsTaskPresets(row));
            }

            TaskcardOutTemplate outTemplate = new TaskcardOutTemplate
            {
                // _118_XEFF = _118_XEFF,
                // _119_XEFFSER = _119_XEFFSER,
                // _308_XMSTASK = _308_XMSTASK,
                // _309_XMSTASKRV = _309_XMSTASKRV,
                // _318_XMSTASKMPD = _318_XMSTASKMPD,
                // _321_XMSTASKIV = _321_XMSTASKIV,
                // _325_XMSTASKWT = _325_XMSTASKWT,
                // _330_XMSTSAKITWS = _330_XMSTSAKITWS,
                // _339_XMSTASKITEF = _339_XMSTASKITEF,
                _350Xmstaskhist = xmstaskhist,
                _351_XMSTASKPEND = xmstaskpends,
                _352_XMSTASKPENDINT = xmstaskpendints,
                _354_XMSTASKPRESET = xmstaskpresets
            };

            return outTemplate;
        }
        private _118_XEFF Get118_XEFF(TaskcardTemplate row)
        {
            var output = new _118_XEFF
            {
                EFF_TITLE = row.EFF_TITLE,
                EFF_TITLE_PAR = "",
                EFF_TITLE_HIGH = "",
                AC_TYPE = "737",
                AC_MODEL = row.AC_MODEL,
                AC_SUB = row.AC_SUB,
                EFF_AC_TYPE = "",
                PARTNO = "", // ?
                SER_TYPE = "", // ?
                CHANGEABLE = "", // ?
                DESCRIPTION = ""
            };
            return output;
        }
        private _119_XEFFSER Get119_XEFFSER(TaskcardTemplate row)
        {
            var output = new _119_XEFFSER
            {
                EFF_TITLE = row.EFF_TITLE,
                RANGE_TYPE = "", // ?
                SERIALNO_FROM = "", // ?
                SERIALNO_TO = "", // ?
                INCL_EXCL = "", // ?
                SER_SHIFT = ""
            };
            return output;
        }
        private _308_XMSTASK Get308_XMSTASK(TaskcardTemplate row)
        {
            var output = new _308_XMSTASK
            {
                MS_NAME = "", // ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = "", // ?
                ATA_CHAPTER = "" // ?
            };
            return output;
        }
        private _309_XMSTASKRV Get309_XMSTASKRV(TaskcardTemplate row)
        {
            var output = new _309_XMSTASKRV
            {
                MS_NAME = "", // ?
                MS_ISSUE = "", // ?
                MS_REVISION = "", // ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = "", // ?
                TITLE = "", // ?
                TASK_REVISION = "ORG", 
                TASK_REVISION_DATE = "", // ?
                TASK_REVISION_REASON = "", // ?
                RELEASE_DATE = "", // ?
                COMPLIANCE = "", // ?
                STATUS = "", // ?
                TASK_TYPE = "", // ?
                INTERVAL_TYPE = "", // ?
                MAXRECURRENCE = "",
                NOT = "",
                MRB_REVISION = "",
                MRB_REVISION_DATE = "",
                MRB_REVISION_REASON = "",
                EST_MH_MRB = "",
                REQ_MAND_REP = "",
                CRX_REV_FLAG = "",
                CP_SEQ = "",
                STATE = "",
                EFF_NOTES = "",
                NOTES = "",
                MRB_TEXT = "",
                REMARKS = ""
            };
            return output;
        }
        private _318_XMSTASKMPD Get318_XMSTASKMPD(TaskcardTemplate row)
        {
            // This one is completely empty in the template rules
            var output = new _318_XMSTASKMPD() { };
            return output;
        }
        private _321_XMSTASKIV Get321_XMSTASKIV(TaskcardTemplate row)
        {
            var output = new _321_XMSTASKIV
            {
                MS_NAME = "", // ?
                MS_ISSUE = "", // ?
                MS_REVISION = "",// ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = "Y",
                TASK_REVISION = "ORG",
                TYPE = "", // ?
                DIM_TYPE = "", // ?
                THR_BASE = "", // ?
                DIM_GROUP = "", // ?
                DIMENSION = "", // ?
                AMOUNT = "", // ?
                THR_BASE_DIM = "", // ?
                THR_BASE_AMOUNT = "", // ?
                UNLIMITED = "", // ?
                TERMINATING = "", // ?
                CALC_LOGIC = "", // ?
                CALC_STRAT = "", // ?
                AUTO_REP_BACK = "", // ?
                NOTES = "" // ?
            }; 
            return output;
        }
        private _325_XMSTASKWT Get325_XMSTASKWT(TaskcardTemplate row)
        {
            var output = new _325_XMSTASKWT
            {
                MS_NAME = "", // ?
                MS_ISSUE = "", // ?
                MS_REVISION = "", // ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = "",// ?
                TASK_REVISION = "",// ?
                REVISION =  "1",
                ATA_CHAPTER = "", // ?
                EVENT_CLASS = "", 
                DEFECT_CLASS = "", 
                PRIO = "",
                PROJECTNO = ""
            };
            return output;
        }
        private _330_XMSTSAKITWS Get330_XMSTSAKITWS(TaskcardTemplate row)
        {
            var output = new _330_XMSTSAKITWS
            {
                MS_NAME = "", // ?
                MS_ISSUE = "", // ?
                MS_REVISION = "", // ?
                TASKNUMBER = "",
                OP_TASK = "", // ?
                TASK_REVISION = "", // ?
                SEQ_NO = "", // ?
                WS_TYPE = "",
                HEADER = "",
                SIGN = "",
                CRITICAL = "",
                DEFUEL = "",
                DOUBLE_INSP = "",
                EL_POWER = "",
                EVENT_OPEN = "",
                EWIS = "",
                EXT_HYRD = "",
                HYDR_OFF = "",
                IDLE_RUN = "",
                INSURANCE = "",
                NDT = "",
                POWER_RUN = "",
                TANK_ENTRY = "",
                TEST_FLIGHT = "",
                TROUBLESHOOTING = "",
                WARRANTY = "",
                ETOPS = "",
                AD = "",
                PHASE = "",
                REVISION = "",
                REV_STATUS = "null", // ?
                TEXT = "", // ?
                COMMENT = "null"
            };
            return output;
        }
        private _339_XMSTASKITEF Get339_XMSTASKITEF(TaskcardTemplate row)
        {
            var output = new _339_XMSTASKITEF
            {
                MS_NAME = "", // ?
                MS_ISSUE = "", // ?
                MS_REVISION = "", // ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = "", // ?
                TASK_REVISION = "", // ?
                EFF_TITLE = row.EFF_TITLE
            }; 
            return output;
        }
        private _350_XMSTASKHIST GetXMsTaskHist(TaskcardTemplate row)
        {
            _350_XMSTASKHIST output = new _350_XMSTASKHIST
            {
                MS_NAME = null, // ?
                MS_ISSUE = null, // ?
                MS_REVISION = null, // ?
                TASKNUMBER = row.TASKNUMBER,
                OP_TASK = null, // ?
                TASK_REVISION = null, // ?
                TASKCARDNO = "", // ?
                TASKCARD_ID = null, // ?
                AC_REGISTR = row.AC_REGISTR,
                MECH_SIGN = "", // ?
                RELEASE_STATION = "", // ?
                RELEASE_TIME = "", // ?
                DUE_TAH = "", // ?
                PERF_TAH = "", // ?
                DUE_TAC = "", // ?
                PERF_TAC = "", // ?
                DUE_DATE = row.DUE_DATE,
                PERF_DATE = row.PERFORMED_DATE,
                UNIQUE_ID = "", // ?
                EVENT_IDENTIFIER = "", // ?
                REMARKS = "" // ?
            };

            return output;
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