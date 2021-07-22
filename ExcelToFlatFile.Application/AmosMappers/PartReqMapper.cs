using System;
using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartReq;
using Org.BouncyCastle.Crypto.Tls;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class PartReqMapper : BaseMapper<PartTemplate, PartReqOutTemplate>
    {
        public override PartReqOutTemplate Map(List<PartTemplate> input)
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
            
            PartReqOutTemplate outTemplate = new PartReqOutTemplate
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
                EFF_TITLE = row.Eff_Title,
                EFF_TITLE_PAR = "",
                EFF_TITLE_HIGH = "",
                AC_TYPE = "737",
                AC_MODEL = "",
                AC_SUB = "",
                EFF_AC_TYPE = "",
                PARTNO = row.PART_NUMBER,
                SER_TYPE = "L",
                CHANGEABLE = "Y",
                DESCRIPTION = row.Part_Req_Description // ? Does not have a length requirement
            };
            return output;
        }
        private _119_XEFFSER GetXEFFSER(PartTemplate row, string controldim)
        {
            var output = new _119_XEFFSER
            {
                EFF_TITLE = row.Eff_Title,
                RANGE_TYPE = row.RANGE_TYPE, // Mandatory if range-type = "S" or "R"
                SERIALNO_FROM = row.SERIALNO_FROM,
                SERIALNO_TO = row.SERIALNO_TO,
                INCL_EXCL = row.INCL_EXCL,
                SER_SHIFT = ""
            };
            return output;
        }
        private _134_XPARTREQ GetXPARTREQ(PartTemplate row, string controldim)
        {
            var output = new _134_XPARTREQ
            {
                PARTREQ_TITLE = row.Part_Req_Title,
                PARTREQ_TYPE = row.REQUIREMENT,
                DESCRIPTION = row.Part_Req_Description,
                REMOVAL_REQ = row.Removal_Req,
                SHELF_PERF = "N",
                HARD_SOFT = "H",
                PRO_RATA = "",
                RATING = ""
            };
            return output;
        }
        private _135_XPARTREQEFFLINK GetXPARTREQEFFLINK(PartTemplate row, string controldim)
        {
            var output = new _135_XPARTREQEFFLINK
            {
                PARTREQ_TITLE = "", // Part Req Type?
                PARTREQ_TYPE = row.REQUIREMENT,
                EFF_TITLE = row.Eff_Title
            };
            return output;
        }
        private _136_XPARTREQTREQ GetXPARTREQTREQ(PartTemplate row, string controldim)
        {
            var output = new _136_XPARTREQTREQ
            {
                PARTREQ_TITLE = "", // Part Req Type?
                PARTREQ_TYPE = row.REQUIREMENT,
                EFF_TITLE = row.Eff_Title,
                DIM_TYPE = row.DIM_TYPE,
                THR_BASE = "",
                FL = "",
                DIM = controldim,
                AMOUNT = GetIntervalAmount(row, controldim),
                THR_BASE0DIM = "",
                THR_BASE_AMOUNT = "",
                UNLIMITED = row.UNLIMITED,
                TERMINATING = row.TERMINATING,
                CALC_STRAT = "1",
                AUTO_REP_BACK = "",
                NOTES = ""
            };
            return output;
        }
        private _137_XPARTREQWT GetXPARTREQWT(PartTemplate row, string controldim)
        {
            var output = new _137_XPARTREQWT
            {
                PARTREQ_TITLE = "", // Part Req Type?
                PARTREQ_TYPE = row.REQUIREMENT,
                EFF_TITLE = row.Eff_Title,
                REVISION = "",
                ATA_CHAPTER = row.ATA,
                EVENT_CLASS = "",
                DEFECT_CLASS = "",
                PRIO = "",
                PROJECTNO = ""
            };
            return output;
        }
        private _139_XPARTREQWS GetXPARTREQWS(PartTemplate row, string controldim)
        {
            var output = new _139_XPARTREQWS
            {
                PARTREQ_TITLE = "",  // Part Req Type?
                PARTREQ_TYPE = row.REQUIREMENT,
                EFF_TITLE = row.Eff_Title,
                SEQ_NO = "1",
                WS_TYPE = "",
                HEADER = "",
                SIGN = "",
                CRITICAL = "",
                DEFUEL = "",
                DOUBLE_INSP = "",
                EL_POWER = "",
                EVENT_OPEN = "",
                EWIS = "",
                EXT_HYDR = "",
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
                REV_STATUS = "",
                TEXT = GetText(row.REQUIREMENT),
                COMMENT = ""
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
                PARTREQ_TITLE = "", // Part Req Type?
                PARTREQ_TYPE = row.REQUIREMENT,
                EFF_TITLE = row.Eff_Title,
                MS_NAME = "MTLM",
                TASKNUMBER = row.TaskcardReference,
                OPERATOR = "VXP",
                PRINT_MODE = "YN"
            };
            return output;
        }

        

        

        

       

      

       


        private _148_XPARTREQHI GetPartReqHI(PartTemplate input, string controlDim)
        {
            var output = new _148_XPARTREQHI()
            {
                PARTREQ_TITLE = input.Part_Req_Title,
                PARTREQ_TYPE = input.REQUIREMENT,
                EFF_TITLE = input.Eff_Title,
                PARTNO = input.PART_NUMBER,
                SERIALNO = input.SERIAL_NUMBER,
                PERF_DATE = input.LAST_REQ_DATE.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("dd.MM.yy"),
                CONTROL_DIM = controlDim,
                DUE_AMOUNT = GetDueAmount(input, controlDim),
                PERF_AMOUNT = GetPerfAmount(input, controlDim),
                UNIQUE_ID = Guid.NewGuid().ToString(),
                EVENT_IDENTIFIER = ""
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
                PARTREQ_TITLE = input.Part_Req_Title,
                PARTREQ_TYPE = input.REQUIREMENT,
                EFF_TITLE = input.Eff_Title,
                PARTNO = input.PART_NUMBER,
                SERIALNO = input.SERIAL_NUMBER,
                DIMENSION = controlDim,
                DUE_AMOUNT = GetDueAmount(input, controlDim),
                EVENT_IDENTIFIER = ""
            };

            return output;
        }
        
    }
}