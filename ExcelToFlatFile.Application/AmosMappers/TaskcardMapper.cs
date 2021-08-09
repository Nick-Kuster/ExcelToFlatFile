using System;
using System.Collections.Generic;
using System.IO;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Taskcard;
using Newtonsoft.Json;
using NPOI.HPSF;
using XFileConverter.Desktop;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class TaskcardMapper : BaseMapper<TaskcardTemplate, _TASKCARD_OUT_TEMPLATE>
    {
        private VariableSettings _varSettings { get; set; }
        public override _TASKCARD_OUT_TEMPLATE Map(List<TaskcardTemplate> input)
        {

            if (File.Exists("VariableSettings.json"))
            {
                string variableSettingsjson = File.ReadAllText("VariableSettings.json");
                _varSettings = JsonConvert.DeserializeObject<VariableSettings>(variableSettingsjson);
            }

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

                if (!string.IsNullOrEmpty(row.DUE_DATE.SetToEmptyIfMatch("UNK")))
                {
                    xmstaskpendints.Add(GetXMsTaskPendInts(row, "D"));
                    xmstaskpresets.Add(GetXMsTaskPresets(row, "D"));
                }

                if (!string.IsNullOrEmpty(row.DUE_HOURS.SetToEmptyIfMatch("UNK")))
                {
                    xmstaskpendints.Add(GetXMsTaskPendInts(row, "H"));
                    xmstaskpresets.Add(GetXMsTaskPresets(row, "H"));
                }

                if (!string.IsNullOrEmpty(row.DUE_CYCLES.SetToEmptyIfMatch("UNK")))
                {
                    xmstaskpendints.Add(GetXMsTaskPendInts(row, "C"));
                    xmstaskpresets.Add(GetXMsTaskPresets(row, "C"));
                }
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
                MsName = _varSettings.MsName,
                MsIssue = _varSettings.MsIssue, 
                MsRevision = _varSettings.MsRevision,
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
                MsName = _varSettings.MsName,
                MsIssue = _varSettings.MsIssue,
                MsRevision = _varSettings.MsRevision,
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
                MsName = _varSettings.MsName,
                MsIssue = _varSettings.MsIssue,
                MsRevision = _varSettings.MsRevision,
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
                MsName = _varSettings.MsName,
                MsIssue = _varSettings.MsIssue,
                MsRevision = _varSettings.MsRevision,
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
                MsName = _varSettings.MsName,
                MsIssue = _varSettings.MsIssue,
                MsRevision = _varSettings.MsRevision,
                TaskNumber = row.TASKNUMBER,
                OpTask = "N", 
                TaskRevision = "ORG",
                TaskcardNo = "", 
                TaskcardId = "",
                AcRegistr = _varSettings.AcRegistr,
                MechSign = "MECH", 
                ReleaseStation = "MIA",
                ReleaseTime = "", 
                DueTah = row.DUE_HOURS,
                PerfTah = row.PERFORMED_HOURS, 
                DueTac = row.DUE_CYCLES,
                PerfTac = row.PERFORMED_CYCLES, 
                DueDate = row.DUE_DATE.ConvertToFormattedDateString("dd.MM.yy"),
                PerfDate = row.PERFORMED_DATE.ConvertToFormattedDateString("dd.MM.yy"),
                UniqueId = Guid.NewGuid().ToString(), 
                EventIdentifier = "", 
                Remarks = ""
            };

            return output;
        }
        private _351_XMSTASKPEND GetXMsTaskPends(TaskcardTemplate input)
        {
            _351_XMSTASKPEND output = new _351_XMSTASKPEND()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = _varSettings.AcRegistr,
                TaskcardNo = "",
                TaskcardId = "",
                EventIdentifier = ""
            };
            return output;
        }
        private _352_XMSTASKPENDINT GetXMsTaskPendInts(TaskcardTemplate input, string controlDim)
        {
            _352_XMSTASKPENDINT output = new _352_XMSTASKPENDINT()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = input.TASKNUMBER,
                Dimension = controlDim,
                AmountDue = GetDueAmount(input, controlDim),
                TaskcardNo = "",
                TaskcardId = ""
            };

            return output;
        }
        private _354_XMSTASKPRESET GetXMsTaskPresets(TaskcardTemplate input, string controlDim)
        {
            _354_XMSTASKPRESET output = new _354_XMSTASKPRESET()
            {
                TaskNumber = input.TASKNUMBER,
                AcRegistr = input.TASKNUMBER,
                Dimension = controlDim, 
                AmountDue = GetDueAmount(input, controlDim),
                DueDayTime = "",
                ChangedDate = "",
                ChangedTime = "",
                ReqLinkHeaderNoOp = "",
                TaskcardNo = "",
                TaskcardId = ""
            };
            return output;
        }

        private string GetDueAmount(TaskcardTemplate input, string controlDim)
        {
            switch (controlDim)
            {
                case "H":
                    return input.DUE_HOURS.MultiplyStringByInt(60);
                case "C":
                    return input.DUE_CYCLES;
                case "D":
                    return input.DUE_DATE.ConvertToFormattedDateString("dd.MM.yy");
                default:
                    return "";
            }
        }
    }
}