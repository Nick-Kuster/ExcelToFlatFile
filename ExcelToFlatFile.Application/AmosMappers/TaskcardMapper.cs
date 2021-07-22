using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard;
using NPOI.SS.Formula.Functions;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class TaskcardMapper : BaseMapper<TaskcardTemplate, _TASKCARD_OUT_TEMPLATE>
    {
        public override _TASKCARD_OUT_TEMPLATE Map(List<TaskcardTemplate> input)
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

            _TASKCARD_OUT_TEMPLATE outTemplate = new _TASKCARD_OUT_TEMPLATE
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
                EffTitle = row.EFF_TITLE,
                EffTitlePar = "",
                EffTitleHigh = "",
                AcType = "737",
                AcModel = row.AC_MODEL,
                AcSub = row.AC_SUB,
                EffAcType = "",
                PartNo = "", // ?
                SerType = "", // ?
                Changeable = "", // ?
                Description = ""
            };
            return output;
        }
        private _119_XEFFSER Get119_XEFFSER(TaskcardTemplate row)
        {
            var output = new _119_XEFFSER
            {
                EffTitle = row.EFF_TITLE,
                RangeType = "", // ?
                SerialNoFrom = "", // ?
                SerialNoTo = "", // ?
                InclExcl = "", // ?
                SerShift = ""
            };
            return output;
        }
        private _308_XMSTASK Get308_XMSTASK(TaskcardTemplate row)
        {
            var output = new _308_XMSTASK
            {
                MsName = "", // ?
                TaskNumber = row.TASKNUMBER,
                OpTask = "", // ?
                AtaChapter = "" // ?
            };
            return output;
        }
        private _309_XMSTASKRV Get309_XMSTASKRV(TaskcardTemplate row)
        {
            var output = new _309_XMSTASKRV
            {
                MsName = "", // ?
                MsIssue = "", // ?
                MsRevision = "", // ?
                TaskNumber = row.TASKNUMBER,
                OpTask = "", // ?
                Title = "", // ?
                TaskRevision = "ORG", 
                TaskRevisionDate = "", // ?
                TaskRevisionReason = "", // ?
                ReleaseDate = "", // ?
                Compliance = "", // ?
                Status = "", // ?
                TaskType = "", // ?
                IntervalType = "", // ?
                MaxRecurrence = "",
                NotApplicable = "",
                MrbRevision = "",
                MrbRevisionDate = "",
                MrbRevisionReason = "",
                EstMhMrb = "",
                ReqMandRep = "",
                CrxRevFlag = "",
                CpSeq = "",
                State = "",
                EffNotes = "",
                Notes = "",
                MrbText = "",
                Remarks = ""
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
                MsName = "", // ?
                MsIssue = "", // ?
                MsRevision = "",// ?
                TaskNumber = row.TASKNUMBER,
                OpTask = "Y",
                TaskRevision = "ORG",
                Type = "", // ?
                DimType = "", // ?
                ThrBase = "", // ?
                DimGroup = "", // ?
                Dimension = "", // ?
                Amount = "", // ?
                ThrBaseDim = "", // ?
                ThrBaseAmount = "", // ?
                Unlimited = "", // ?
                Terminating = "", // ?
                CalcLogic = "", // ?
                CalcStrat = "", // ?
                AutoRepBack = "", // ?
                Notes = "" // ?
            }; 
            return output;
        }
        private _325_XMSTASKWT Get325_XMSTASKWT(TaskcardTemplate row)
        {
            var output = new _325_XMSTASKWT
            {
                MsName = "", // ?
                MsIssue = "", // ?
                MsRevision = "", // ?
                TaskNumber = row.TASKNUMBER,
                OpTask = "",// ?
                TaskRevision = "",// ?
                Revision =  "1",
                AtaChapter = "", // ?
                EventClass = "", 
                DefectClass = "", 
                Prio = "",
                ProjectNo = ""
            };
            return output;
        }
        private _330_XMSTSAKITWS Get330_XMSTSAKITWS(TaskcardTemplate row)
        {
            var output = new _330_XMSTSAKITWS
            {
                MsName = "", // ?
                MsIssue = "", // ?
                MsRevision = "", // ?
                TaskNumber = "",
                OpTask = "", // ?
                TaskRevision = "", // ?
                SeqNo = "", // ?
                WsType = "",
                Header = "",
                Sign = "",
                Critical = "",
                Defuel = "",
                DoubleInsp = "",
                ElPower = "",
                EventOpen = "",
                Ewis = "",
                ExtHyrd = "",
                HydrOff = "",
                IdleRun = "",
                Insurance = "",
                Ndt = "",
                PowerRun = "",
                TankEntry = "",
                TestFlight = "",
                Troubleshooting = "",
                Warranty = "",
                Etops = "",
                Ad = "",
                Phase = "",
                Revision = "",
                RevStatus = "null", // ?
                Text = "", // ?
                Comment = "null"
            };
            return output;
        }
        private _339_XMSTASKITEF Get339_XMSTASKITEF(TaskcardTemplate row)
        {
            var output = new _339_XMSTASKITEF
            {
                MsName = "", // ?
                MsIssue = "", // ?
                MsRevision = "", // ?
                TaskNumber = row.TASKNUMBER,
                OpTask = "", // ?
                TaskRevision = "", // ?
                EffTitle = row.EFF_TITLE
            }; 
            return output;
        }
        private _350_XMSTASKHIST GetXMsTaskHist(TaskcardTemplate row)
        {
            _350_XMSTASKHIST output = new _350_XMSTASKHIST
            {
                MsName = null, // ?
                MsIssue = null, // ?
                MsRevision = null, // ?
                TaskNumber = row.TASKNUMBER,
                OpTask = null, // ?
                TaskRevision = null, // ?
                TaskcardNo = "", // ?
                TaskcardId = null, // ?
                AcRegistr = row.AC_REGISTR,
                MechSign = "", // ?
                ReleaseStation = "", // ?
                ReleaseTime = "", // ?
                DueTah = "", // ?
                PerfTah = "", // ?
                DueTac = "", // ?
                PerfTac = "", // ?
                DueDate = row.DUE_DATE,
                PerfDate = row.PERFORMED_DATE,
                UniqueId = "", // ?
                EventIdentifier = "", // ?
                Remarks = "" // ?
            };

            return output;
        }
        private _351_XMSTASKPEND GetXMsTaskPends(TaskcardTemplate input)
        {
            _351_XMSTASKPEND output = new _351_XMSTASKPEND()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = input.TASKNUMBER,
                TaskcardNo = "",
                TaskcardId = "",
                EventIdentifier = ""
            };
            return output;
        }
        private _352_XMSTASKPENDINT GetXMsTaskPendInts(TaskcardTemplate input)
        {
            _352_XMSTASKPENDINT output = new _352_XMSTASKPENDINT()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = input.TASKNUMBER,
                Dimension = "", // Do not have this in template
                AmountDue = "",
                TaskcardNo = "",
                TaskcardId = ""
            };

            return output;
        }
        private _354_XMSTASKPRESET GetXMsTaskPresets(TaskcardTemplate input)
        {
            _354_XMSTASKPRESET output = new _354_XMSTASKPRESET()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = input.TASKNUMBER,
                Dimension = "", // Not in Template
                AmountDue = "", // Dimension not in template
                DueDayTime = "",
                ChangedDate = "",
                ChangedTime = "",
                ReqLinkHeaderNoOp = "",
                TaskcardNo = "",
                TaskcardId = ""
            };
            return output;
        }

        

        

        
    }
}