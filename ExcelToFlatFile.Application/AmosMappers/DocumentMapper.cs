using System.Collections.Generic;
using System.ComponentModel;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class DocumentMapper : BaseMapper<DocumentTemplate, DocumentOutTemplate>
    {
        public override DocumentOutTemplate Map(List<DocumentTemplate> input)
        {
            List<_118_XEFF> _118_XEFF = new List<_118_XEFF>();
            List<_119_XEFFSER> _119_XEFFSER = new List<_119_XEFFSER>();
            List<_240_XDHE> _240_XDHE = new List<_240_XDHE>();
            List<_241_XDCOMPACTYPE> _241_XDCOMPACTYPE = new List<_241_XDCOMPACTYPE>();
            List<_243_XDHETX> _243_XDHETX = new List<_243_XDHETX>();
            List<_245_XDWS> _245_XDWS = new List<_245_XDWS>();
            List<_247_XDHECT> _247_XDHECT = new List<_247_XDHECT>();
            List<_255_XDEFFLINK> _255_XDEFFLINK = new List<_255_XDEFFLINK>();
            List<_259_XDEFFTREQ> _259_XDEFFTREQ = new List<_259_XDEFFTREQ>();
            List<_260_XDEFFWT> _260_XDEFFWT = new List<_260_XDEFFWT>();
            List<_262_XDEFFWS> _262_XDEFFWS = new List<_262_XDEFFWS>();
            List<_268_XDHIST> _268_XDHIST = new List<_268_XDHIST>();
            List<_269_XDPEND> _269_XDPEND = new List<_269_XDPEND>();
            List<XDSOFF> XDSOFF = new List<XDSOFF>();

            foreach (var row in input)
            {
                // _118_XEFF.Add(GetXEFF(row));
                // _119_XEFFSER.Add(GetXEFFSER(row));
                // _240_XDHE.Add(GetXDHE(row));
                // // ONLY documents with "AC-OR-COMP" =  "C" gets an entry in this file (241)
                // _241_XDCOMPACTYPE.Add(GetXDCOMPACTYPE(row));
                // _243_XDHETX.Add(GetXDHETX(row));
                // _245_XDWS.Add(GetXDWS(row));
                // _247_XDHECT.Add(GetXDHECT(row));
                // _255_XDEFFLINK.Add(GetXDEFFLINK(row));
                // _259_XDEFFTREQ.Add(GetXDEFFTREQ(row));
                // _260_XDEFFWT.Add(GetXDEFFWT(row));
                // _262_XDEFFWS.Add(GetXDEFFWS(row));
                _268_XDHIST.Add(GetXDHist(row));
                _269_XDPEND.Add(GetXDPends(row));
                // XDSOFF.Add(GetXDSOFF(row));
            }

            DocumentOutTemplate outTemplate = new DocumentOutTemplate()
            {
                // _118_XEFF = _118_XEFF,
                // _119_XEFFSER = _119_XEFFSER,
                // _240_XDHE = _240_XDHE,
                // _241_XDCOMPACTYPE = _241_XDCOMPACTYPE,
                // _243_XDHETX = _243_XDHETX,
                // _245_XDWS = _245_XDWS,
                // _247_XDHECT = _247_XDHECT,
                // _255_XDEFFLINK = _255_XDEFFLINK,
                // _259_XDEFFTREQ = _259_XDEFFTREQ,
                // _260_XDEFFWT = _260_XDEFFWT,
                // _262_XDEFFWS = _262_XDEFFWS,
                _268_XDHISTS = _268_XDHIST,
                _269_XDPENDS = _269_XDPEND,
                // XDSOFF = XDSOFF
            };

            return outTemplate;
        }
        private _118_XEFF GetXEFF(DocumentTemplate row)
        {
            var output = new _118_XEFF
            {
                EFF_TITLE = row.EFF_TITLE,
                EFF_TITLE_PAR = "",
                EFF_TITLE_HIGH = "",
                AC_TYPE = row.AC_TYPE,
                AC_MODEL = row.AC_MODEL,
                AC_SUB = row.AC_SUB,
                EFF_AC_TYPE = "",
                PARTNO = row.PartNo,
                SER_TYPE = "", // ?
                CHANGEABLE = "", // ?
                DESCRIPTION = "" // ?
            };

            return output;
        }
        private _119_XEFFSER GetXEFFSER(DocumentTemplate row)
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
        private _240_XDHE GetXDHE(DocumentTemplate row)
        {
            var output = new _240_XDHE
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                AC_OR_COMP = row.AC_OR_COMP,
                ATA_CHAPTER = row.ATA_CHAPTER,
                COMPLIANCE = "?",
                TEXT1 = row.TEXT1,
                TEXT2 = row.TEXT2,
                REV_DATE = row.REV_DATE,
                ISSUE_DATE = row.ISSUE_DATE,
                REC_DATE = "",
                TIME_LIMIT = row.TIME_LIMIT,
                REPETITIVE = row.REPETITIVE,
                EST_GROUDTIME = "",
                EFFECTIVE_DATE = row.EFFECTIVE_DATE,
                OPS_AFFECTED = "",
                SIM_AFFECTED = "",
                REMOVAL_REQ = "",
                SHOP_OR_LINE = "",
                CONTROLLED_BY = "",
                TYPE_OF_CHANGE = "",
                WARRANTY_LABOUR = "",
                WARRANTY_MAT = "",
                EST_MH_DOC = "",
                ORG_DOCNO = "",
                ORG_DOC_TYPE = "",
                LABOUR_COST = "",
                MAT_COST = "",
                MOD_CAMPAIGN = "",
                MOD_ATTRITION = "",
                COSTCENTER = "",
                COST_TYPE = "",
                RELEASE_STATE = "",
                INSPECTION = "",
                ASSESS_RESP = "",
                ASSESS_START = "",
                ASSESS_END = "",
                GRND_OPS_AFF = "",
                TRIAL_INST = "",
                OCCASION = "",
                UUID = "",
                IMP_NOTES = ""
            }; 
            return output;
        }
        private _241_XDCOMPACTYPE GetXDCOMPACTYPE(DocumentTemplate row)
        {
            // ONLY documents with "AC-OR-COMP" =  "C" gets an entry in this file
            var output = new _241_XDCOMPACTYPE
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                AC_TYPE = "737"
            }; 
            return output;
        }
        private _243_XDHETX GetXDHETX(DocumentTemplate row)
        {
            var output = new _243_XDHETX
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                TEXT = row.TEXT1
            };
            return output;
        }
        
        private _245_XDWS GetXDWS(DocumentTemplate row)
        {
            var output = new _245_XDWS
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                SEQ_NO = "?",
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
                WS_REV = "",
                REV_STATUS = "", // ?
                TEXT = row.TEXT, // This says "Columns" (plural)... does it want all 3 text fields from template?
                COMMENT = ""
            };
            return output;
        }
        private _247_XDHECT GetXDHECT(DocumentTemplate row)
        {
            var output = new _247_XDHECT
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                TEXT = row.TEXT1
            };
            return output;
        }
        private _255_XDEFFLINK GetXDEFFLINK(DocumentTemplate row)
        {
            var output = new _255_XDEFFLINK
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
                AUTO_STATUS = "",
                NEXT_SHOPVIS = "",
                PRINT_REL0CERT = ""
            }; 
            return output;
        }
        private _259_XDEFFTREQ GetXDEFFTREQ(DocumentTemplate row)
        {
            var output = new _259_XDEFFTREQ
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
                DIM_TYPE = "", // ?
                THR_BASE = "",// ?
                FL = "", // ?
                DIM_GROUP = "",
                DIM = "", // ?
                AMOUNT = "", // ?
                THR_BASE_DIM = "",
                THR_BASE_AMOUNT = "",
                UNLIMITED = row.UNLIMITED,
                TERMINATING = "", // ?
                CALC_STRAT = "", // ?
                AUTO_REP_BACK = ""
            }; return output;
        }

        private _260_XDEFFWT GetXDEFFWT(DocumentTemplate row)
        {
            var output = new _260_XDEFFWT
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
                WT_REVISION = "",
                ATA_CHAPTER = row.ATA_CHAPTER,
                EVENT_CLASS = "",
                DEFECT_CLASS = "",
                PRIO = "",
                PROJECTNO = ""
            };
            return output;
        }
        private _262_XDEFFWS GetXDEFFWS(DocumentTemplate row)
        {
            var output = new _262_XDEFFWS
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
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
                WS_REV = "",
                REV_STATUS = "", // ?
                TEXT = row.TEXT, // This says "Columns" (plural)... does it want all 3 text fields from template?
                COMMENT = ""
            }; return output;
        }
        
        private _268_XDHIST GetXDHist(DocumentTemplate row)
        {
            _268_XDHIST output = new _268_XDHIST()
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
                AC_REGISTR = row.AC_REGISTR,
                PARTNO = row.PartNo,
                SERIALNUMBER = row.SerialNumber,
                PERF_HOURS = row.PERF_HOURS.MultiplyStringByInt(60),
                PERF_CYCLES = row.PERF_CYCLES,
                PERF_DATE = row.PERF_DATE.ConvertToFormattedDateString("dd.MM.yyyy"),
                DIM_1 = "",
                DUE_AMOUNT_1 = "",
                PERF_AMOUNT_1 = "",
                DIM_2 = "",
                DUE_AMOUNT_2 = "",
                PERF_AMOUNT_2 = "",
                DIM_3 = "",
                DUE_AMOUNT_3 = "",
                PERF_AMOUNT_3 = "",
                PERF_STATUS = row.STATUS,
                PARTLY_PERF = "N",
                PERF_REFDOC = "",
                PERF_CUSTOMER_WO = "",
                UNIQUE_ROT_ID = "",
                IS_LAST_HISTORY = "Y",
                EVENT_IDENTIFIER = "",
                PERF_TEXT = ""
            };

            return output;
        }
        private _269_XDPEND GetXDPends(DocumentTemplate row)
        {
            _269_XDPEND output = new _269_XDPEND()
            {
                DOCNO = row.DOCNO,
                DOC_TYPE = row.DOC_TYPE,
                REVISION = row.REVISION,
                ISSUED_BY = row.ISSUED_BY,
                EFF_TITLE = row.EFF_TITLE,
                AC_REGISTR = row.AC_REGISTR,
                PARTNO = row.PartNo,
                SERIALNUMBER = row.SerialNumber,
                OPEN_STATUS = row.STATUS,
                DUE_CUSTOMER_WO = "",
                EVENT_IDENTIFIER = ""
            };
            FillDueDIMLogic(output, row);
            return output;
        }
        private XDSOFF GetXDSOFF(DocumentTemplate row)
        {
            var output = new XDSOFF
            {
                DOCNO_1 = row.DOCNO,
                DOC_TYPE_1 = row.DOC_TYPE,
                REVISION_1 = row.REVISION,
                ISSUED_BY_1 = row.ISSUED_BY,
                DOCNO_2 = row.DOCNO,
                DOC_TYPE_2 = row.DOC_TYPE,
                REVISION_2 = row.REVISION,
                ISSUED_BY_2 = row.ISSUED_BY
            };
            return output;
        }
        
        private void FillDueDIMLogic(_269_XDPEND output, DocumentTemplate row)
        {
            List<string> dueList = new List<string>();
            List<string> dimensionList = new List<string>();
            if (string.IsNullOrEmpty(row.DUE_HOURS))
            {
                dueList.Add(row.DUE_HOURS.MultiplyStringByInt(60));
                dimensionList.Add("H");
            }

            if (string.IsNullOrEmpty(row.DUE_CYCLES))
            {
                dueList.Add(row.DUE_CYCLES);
                dimensionList.Add("C");
            }

            if (string.IsNullOrEmpty(row.DUE_DATE))
            {
                dueList.Add(row.DUE_DATE.ConvertToFormattedDateString("dd.MM.yyyy"));
                dimensionList.Add("D");
            }

            if (dueList.Count >= 1)
            {
                output.DUE_DIM_1 = dimensionList[0];
                output.DUE_AMOUNT_1 = dueList[0];
            }
            if (dueList.Count >= 2)
            {
                output.DUE_DIM_2 = dimensionList[1];
                output.DUE_AMOUNT_2 = dueList[1];
            }
            if (dueList.Count >= 3)
            {
                output.DUE_DIM_3 = dimensionList[2];
                output.DUE_AMOUNT_3 = dueList[2];
            }
        }
    }
}