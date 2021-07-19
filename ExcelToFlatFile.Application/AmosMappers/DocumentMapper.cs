using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class DocumentMapper : BaseMapper<DocumentTemplate, DocumentOutTemplate>
    {
        public override DocumentOutTemplate Map(List<DocumentTemplate> input)
        {
            List<_268_XDHIST> xDHists = new List<_268_XDHIST>();
            List<_269_XDPEND> xDPends = new List<_269_XDPEND>();

            foreach (var row in input)
            {
                xDHists.Add(GetXDHist(row));
                xDPends.Add(GetXDPends(row));
            }

            DocumentOutTemplate outTemplate = new DocumentOutTemplate()
            {
                _268_XDHISTS = xDHists,
                _269_XDPENDS = xDPends
            };

            return outTemplate;
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