using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Checks;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class CheckMapper : BaseMapper<ChecksTemplate, ChecksOutTemplate>
    {
        public override ChecksOutTemplate Map(List<ChecksTemplate> input)
        {
            List<_294_XCHECKHI> xCheckHis = new List<_294_XCHECKHI>();
            // List<_118_XEFF> _118_XEFF = new List<_118_XEFF>();
            // List<_119_XEFFSER> _119_XEFFSER = new List<_119_XEFFSER>();
            // List<_281_XCHECKTY> _281_XCHECKTY = new List<_281_XCHECKTY>();
            // List<_282_XCHECKEFFLINK> _282_XCHECKEFFLINK = new List<_282_XCHECKEFFLINK>();
            // List<_284_XCHECKEFFTREQ> _284_XCHECKEFFTREQ = new List<_284_XCHECKEFFTREQ>();
            // List<_285_XCHECKEFFWT> _285_XCHECKEFFWT = new List<_285_XCHECKEFFWT>();
            // List<_287_XCHECKEFFWS> _287_XCHECKEFFWS = new List<_287_XCHECKEFFWS>();
            // List<_295_XCHECKPE> _295_XCHECKPE = new List<_295_XCHECKPE>();

            foreach (var row in input)
            {
                xCheckHis.Add(GetXCheckHis(row));
                // _118_XEFF.Add(GetXEff(row));
                // _119_XEFFSER.Add(GetXEffSer(row));
                // _281_XCHECKTY.Add(GetXCheckTy(row));
                // _282_XCHECKEFFLINK.Add(GetXCheckEffLink(row));
                // _284_XCHECKEFFTREQ.Add(GetXCheckEffTReq(row));
                // _285_XCHECKEFFWT.Add(GetXCheckEffWT(row));
                // _287_XCHECKEFFWS.Add(GetXCheckEffWS(row));
                // _295_XCHECKPE.Add(GetXCheckPE(row));
            }

            ChecksOutTemplate outTemplate = new ChecksOutTemplate()
            {
                _294_XCHECKHI = xCheckHis,
                // _118_XEFF = _118_XEFF,
                // _119_XEFFSER = _119_XEFFSER,
                // _281_XCHECKTY = _281_XCHECKTY,
                // _295_XCHECKPE = _295_XCHECKPE,
                // _285_XCHECKEFFWT = _285_XCHECKEFFWT,
                // _287_XCHECKEFFWS = _287_XCHECKEFFWS,
                // _282_XCHECKEFFLINK = _282_XCHECKEFFLINK,
                // _284_XCHECKEFFTREQ = _284_XCHECKEFFTREQ
            };

            return outTemplate;
        }
        private _118_XEFF GetXEff(ChecksTemplate row)
        {
            var output = new _118_XEFF
            {
                EFF_TITLE = row.EFF_TITLE,
                EFF_TITLE_PAR = "",
                EFF_TITLE_HIGH = "", // ?
                AC_TYPE = "", // ?
                AC_MODEL = "", // ?
                AC_SUB = null, // ?
                EFF_AC_TYPE = "",
                PARTNO = "",
                SER_TYPE = "", // ?
                CHANGEABLE = "", // ?
                DESCRIPTION = ""
            };

            return output;
        }
        private _119_XEFFSER GetXEffSer(ChecksTemplate row)
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
        private _281_XCHECKTY GetXCheckTy(ChecksTemplate row)
        {
            var output = new _281_XCHECKTY
            {
                CHECK_TYPE = row.CHECK_TYPE,
                DESCRIPTION = "", // ?
                DEFAULT_STATION = "",
                NBR_OF_INTERNAL_CHECKS = "", // ?
                HAS_LIMIT = "", // ?
                LETTERCHECK = "", // ?
                COMPLIANCE = "", // ?
                CATEGORY = ""
            };
            return output;
        }
        private _282_XCHECKEFFLINK GetXCheckEffLink(ChecksTemplate row)
        {
            var output = new _282_XCHECKEFFLINK
            {
                CHECK_TYPE = row.CHECK_TYPE,
                EFF_TITLE = row.EFF_TITLE
            };

            return output;
        }
        private _284_XCHECKEFFTREQ GetXCheckEffTReq(ChecksTemplate row)
        {
            var output = new _284_XCHECKEFFTREQ
            {
                CHECK_TYPE = row.CHECK_TYPE,
                INTERNAL_CHECK = "", // ?
                EFF_TITLE = row.EFF_TITLE,
                DIM_TYPE = "", // ?
                FL = "", // ?
                DIM = "", // ?
                AMOUNT = "", // ?
                THR_BASE = "",
                THR_BASE_DIM = "",
                THR_BASE_AMOUNT = "",
                UNLIMITED = "", // ?
                TERMINATING = "", // ?
                CALC_STRAT = "", // ?
                AUTO_REP_BACK = ""
            };

            return output;
        }
        private _285_XCHECKEFFWT GetXCheckEffWT(ChecksTemplate row)
        {
            var output = new _285_XCHECKEFFWT
            {
                CHECK_TYPE = row.CHECK_TYPE,
                INTERNAL_CHECK = row.CHECK_TYPE,
                EFF_TITLE = row.EFF_TITLE,
                REVISION = "", // ?
                ATA_CHAPTER = "", // ?
                EVENT_CLASS = "",
                DEFECT_CLASS = "",
                PRIO = "",
                PROJECTNO = ""
            };

            return output;
        }
        private _287_XCHECKEFFWS GetXCheckEffWS(ChecksTemplate row)
        {
            var output = new _287_XCHECKEFFWS
            {
                CHECK_TYPE = row.CHECK_TYPE,
                INTERNAL_CHECK = row.CHECK_TYPE,
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
                REVISION = "",
                REV_STATUS = "", // ?
                TEXT = "", // ?
                COMMENT = ""
            };

            return output;
        }
        private _294_XCHECKHI GetXCheckHis(ChecksTemplate row)
        {
            var output = new _294_XCHECKHI()
            {
                CHECK_TYPE = row.CHECK_TYPE,
                INTERNAL_CHECK = row.CHECK_TYPE,
                EFF_TITLE = row.EFF_TITLE,
                AIRCRAFT = row.Aircraft,
                PERF_TAH = row.PERF_TAH,
                PERF_TAC = row.PERF_TAC,
                PERF_DATE = row.PERF_DATE,
                CONTROL_DIM_1 = "",
                DUE_AMOUNT_1 = "",
                PERF_AMOUNT_1 = "",
                CONTROL_DIM_2 = "",
                DUE_AMOUNT_2 = "",
                PERF_AMOUNT_2 = "",
                CONTROL_DIM_3 = "",
                DUE_AMOUNT_3 = "",
                PERF_AMOUNT_3 = "",
                PERF_CUSTOMER_WO = "",
                EVENT_IDENTIFIER = ""
            };

            return output;
        }
        private _295_XCHECKPE GetXCheckPE(ChecksTemplate row)
        {
            var output = new _295_XCHECKPE
            {
                CHECK_TYPE = row.CHECK_TYPE,
                INTERNAL_CHECK = "", // ?
                EFF_TITLE = row.EFF_TITLE,
                AIRCRAFT = row.Aircraft,
                NEVER_PERFORMED = row.NEVER_PERFORMED,
                CONTROL_DIM_1 = "",  // ?
                DUE_AMOUNT_1 = "",  // ?
                CONTROL_DIM_2 = "",  // ?
                DUE_AMOUNT_2 = "",  // ?
                CONTROL_DIM_3 = "",  // ?
                DUE_AMOUNT_3 = "",  // ?
                EVENT_IDENTIFIER = "" 
            };

            return output;
        }
    }
}