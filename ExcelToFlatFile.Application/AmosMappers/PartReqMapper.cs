using System;
using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartReq;
using Org.BouncyCastle.Crypto.Tls;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class PartReqMapper : BaseMapper<PartTemplate, _PART_REQ_OUT_TEMPLATE>
    {
        public override _PART_REQ_OUT_TEMPLATE Map(List<PartTemplate> input)
        {
            // List<_118_XEFF> _118_XEFF = new List<_118_XEFF>();
            // List<_119_XEFFSER> _119_XEFFSER = new List<_119_XEFFSER>();
            // List<_134_XPARTREQ> _134_XPARTREQ = new List<_134_XPARTREQ>();
            // List<_135_XPARTREQEFFLINK> _135_XPARTREQEFFLINK = new List<_135_XPARTREQEFFLINK>();
            // List<_136_XPARTREQTREQ> _136_XPARTREQTREQ = new List<_136_XPARTREQTREQ>();
            // List<_137_XPARTREQWT> _137_XPARTREQWT = new List<_137_XPARTREQWT>();
            // List<_139_XPARTREQWS> _139_XPARTREQWS = new List<_139_XPARTREQWS>();
            // List<_147_XPARTREQTC> _147_XPARTREQTC = new List<_147_XPARTREQTC>();
            List<_148_XPARTREQHI> xPartReqHiList = new List<_148_XPARTREQHI>();
            List<_149_XPARTREQPE> xPartReqPEList = new List<_149_XPARTREQPE>();
            
            foreach (var row in input)
            {
                // _118_XEFF.Add(GetXEFF(row, "controlDim"));
                // _119_XEFFSER.Add(GetXEFFSER(row, "controlDim"));
                // _134_XPARTREQ.Add(GetXPARTREQ(row, "controlDim"));
                // _135_XPARTREQEFFLINK.Add(GetXPARTREQEFFLINK(row, "controlDim"));
                // _136_XPARTREQTREQ.Add(GetXPARTREQTREQ(row, "controlDim"));
                // _137_XPARTREQWT.Add(GetXPARTREQWT(row, "controlDim"));
                // _139_XPARTREQWS.Add(GetXPARTREQWS(row, "controlDim"));
                // _147_XPARTREQTC.Add(GetXPARTREQTC(row, "controlDim"));
                //Always need LAST_REQ_DATE. Other two are only necessary if LAST_REQ_DATE is present as well as one or both of the others.
                if (!string.IsNullOrEmpty(row.LAST_REQ_DATE.SetToEmptyIfMatch("UNK")))
                {
                    xPartReqHiList.Add(GetPartReqHI(row, "D"));
                    xPartReqPEList.Add(GetPartReqPE(row, "D"));
                    
                    if (!string.IsNullOrEmpty(row.LAST_REQ_TSN.SetToEmptyIfMatch("UNK")))
                    {
                        xPartReqHiList.Add(GetPartReqHI(row, "H"));
                        xPartReqPEList.Add(GetPartReqPE(row, "H"));
                    }
                    if (!string.IsNullOrEmpty(row.LAST_REQ_CYCLES.SetToEmptyIfMatch("UNK")))
                    {
                        xPartReqHiList.Add(GetPartReqHI(row, "C"));
                        xPartReqPEList.Add(GetPartReqPE(row, "C"));
                    }
                }
            }
            
            _PART_REQ_OUT_TEMPLATE outTemplate = new _PART_REQ_OUT_TEMPLATE
            {
                // _118_XEFF = _118_XEFF,
                // _119_XEFFSER = _119_XEFFSER,
                // _134_XPARTREQ = _134_XPARTREQ,
                // _135_XPARTREQEFFLINK = _135_XPARTREQEFFLINK,
                // _136_XPARTREQTREQ = _136_XPARTREQTREQ,
                // _137_XPARTREQWT = _137_XPARTREQWT,
                // _139_XPARTREQWS = _139_XPARTREQWS,
                // _147_XPARTREQTC = _147_XPARTREQTC,
                _148_XPARTREQHI = xPartReqHiList,
                _149_XPARTREQPE = xPartReqPEList
            };

            return outTemplate;
        }

        private _118_XEFF GetXEFF(PartTemplate row, string controldim)
        {
            var output = new _118_XEFF
            {
                EffTitle = row.Eff_Title,
                EffTitlePar = "",
                EffTitleHigh = "",
                AcType = "737",
                AcModel = "",
                AcSub = "",
                EffAcType = "",
                PartNo = row.PART_NUMBER,
                SerType = "L",
                Changeable = "Y",
                Description = row.Part_Req_Description // ? Does not have a length requirement
            };
            return output;
        }
        private _119_XEFFSER GetXEFFSER(PartTemplate row, string controldim)
        {
            var output = new _119_XEFFSER
            {
                EffTitle = row.Eff_Title,
                RangeType = row.RANGE_TYPE, // Mandatory if range-type = "S" or "R"
                SerialNoFrom = row.SERIALNO_FROM,
                SerialNoTo = row.SERIALNO_TO,
                InclExcl = row.INCL_EXCL,
                SerShift = ""
            };
            return output;
        }
        private _134_XPARTREQ GetXPARTREQ(PartTemplate row, string controldim)
        {
            var output = new _134_XPARTREQ
            {
                PartReqTitle = row.Part_Req_Title,
                PartReqType = row.REQUIREMENT,
                Description = row.Part_Req_Description,
                RemovalReq = row.Removal_Req,
                ShelfPerf = "N",
                HardSoft = "H",
                ProRata = "",
                Rating = ""
            };
            return output;
        }
        private _135_XPARTREQEFFLINK GetXPARTREQEFFLINK(PartTemplate row, string controldim)
        {
            var output = new _135_XPARTREQEFFLINK
            {
                PartReqTitle = "", // Part Req Type?
                PartReqType = row.REQUIREMENT,
                EffTitle = row.Eff_Title
            };
            return output;
        }
        private _136_XPARTREQTREQ GetXPARTREQTREQ(PartTemplate row, string controldim)
        {
            var output = new _136_XPARTREQTREQ
            {
                PartReqTitle = "", // Part Req Type?
                PartReqType = row.REQUIREMENT,
                EffTitle = row.Eff_Title,
                DimType = row.DIM_TYPE,
                ThrBase = "",
                Fl = "",
                Dim = controldim,
                Amount = GetIntervalAmount(row, controldim),
                ThrBase0Dim = "",
                ThrBaseAmount = "",
                Unlimited = row.UNLIMITED,
                Terminating = row.TERMINATING,
                CalcStrat = "1",
                AutoRepBack = "",
                Notes = ""
            };
            return output;
        }
        private _137_XPARTREQWT GetXPARTREQWT(PartTemplate row, string controldim)
        {
            var output = new _137_XPARTREQWT
            {
                PartReqTitle = "", // Part Req Type?
                PartReqType = row.REQUIREMENT,
                EffTitle = row.Eff_Title,
                Revision = "",
                AtaChapter = row.ATA,
                EventClass = "",
                DefectClass = "",
                Prio = "",
                ProjectNo = ""
            };
            return output;
        }
        private _139_XPARTREQWS GetXPARTREQWS(PartTemplate row, string controldim)
        {
            var output = new _139_XPARTREQWS
            {
                PartReqTitle = "",  // Part Req Type?
                PartReqType = row.REQUIREMENT,
                EffTitle = row.Eff_Title,
                SeqNo = "1",
                WsType = "",
                Header = "",
                Sign = "",
                Critical = "",
                Defuel = "",
                DoubleInsp = "",
                ElPower = "",
                EventOpen = "",
                Ewis = "",
                ExtHydr = "",
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
                RevStatus = "",
                Text = GetText(row.REQUIREMENT),
                Comment = ""
            };
            return output;
        }

        private string GetText(string requirement)
        {
            switch (requirement)
            {
                case "LL":
                    return "LIFE LIMIT";
                case "OH":
                    return "OVERHAUL";
                case "RS":
                    return "RESTORE";
                case "HT":
                    return "HYDROSTATIC TEST";
                case "TE":
                    return "TEST";
                case "WC":
                    return "WEIGHT CHECK";
                case "FC":
                    return "FUNCTIONAL CHECK";
                case "BO":
                    return "BORESCOPE INSPECTION";
                case "IN":
                    return "INSPECTION";
                case "LB":
                    return "LUBRICATE";
                case "OP":
                    return "OPERATIONAL CHECK";
                default:
                    return "";
            }
        }

        private _147_XPARTREQTC GetXPARTREQTC(PartTemplate row, string controldim)
        {
            var output = new _147_XPARTREQTC
            {
                PartReqTitle = "", // Part Req Type?
                PartReqType = row.REQUIREMENT,
                EffTitle = row.Eff_Title,
                MsName = "MTLM",
                TaskNumber = row.TaskcardReference,
                Operator = "VXP",
                PrintMode = "YN"
            };
            return output;
        }

        

        

        

       

      

       


        private _148_XPARTREQHI GetPartReqHI(PartTemplate input, string controlDim)
        {
            var output = new _148_XPARTREQHI()
            {
                PartReqTitle = input.Part_Req_Title,
                PartReqType = input.REQUIREMENT,
                EffTitle = input.Eff_Title,
                PartNo = input.PART_NUMBER,
                SerialNo = input.SERIAL_NUMBER,
                PerfDate = input.LAST_REQ_DATE.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("dd.MM.yy"),
                ControlDim = controlDim,
                DueAmount = GetDueAmount(input, controlDim),
                PerfAmount = GetPerfAmount(input, controlDim),
                UniqueId = Guid.NewGuid().ToString(),
                EventIdentifier = ""
            };

            return output;
        }

        private string GetDueAmount(PartTemplate input, string controlDim)
        {
            switch (controlDim)
            {
                case "H":
                    return input.NEXT_DUE_FH.MultiplyStringByInt(60);
                case "C":
                    return input.NEXT_DUE_FC;
                case "D":
                    return input.NEXT_DUE_DATE.ConvertToFormattedDateString("dd.MM.yy");
                default:
                    return "";
            }
        }
        
        private string GetPerfAmount(PartTemplate input, string controlDim)
        {
            switch (controlDim)
            {
                case "H":
                    return input.LAST_REQ_TSN.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60);
                case "C":
                    return input.LAST_REQ_CYCLES.SetToEmptyIfMatch("UNK");
                case "D":
                    return input.LAST_REQ_DATE.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("dd.MM.yy");
                default:
                    return "";
            }
        }
        private string GetIntervalAmount(PartTemplate input, string controlDim)
        {
            switch (controlDim)
            {
                case "H":
                    return input.IntervalAmount.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60);
                case "C":
                    return input.IntervalAmount.SetToEmptyIfMatch("UNK");
                case "D":
                    return input.IntervalAmount.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("dd.MM.yy");
                default:
                    return "";
            }
        }
        
        private _149_XPARTREQPE GetPartReqPE(PartTemplate input, string controlDim)
        {
            var output = new _149_XPARTREQPE()
            {
                PartReqTitle = input.Part_Req_Title,
                PartReqType = input.REQUIREMENT,
                EffTitle = input.Eff_Title,
                PartNo = input.PART_NUMBER,
                SerialNo = input.SERIAL_NUMBER,
                Dimension = controlDim,
                DueAmount = GetDueAmount(input, controlDim),
                EventIdentifier = ""
            };

            return output;
        }
        
    }
}