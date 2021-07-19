using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Checks;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class CheckMapper : BaseMapper<ChecksTemplate, ChecksOutTemplate>
    {
        public override ChecksOutTemplate Map(List<ChecksTemplate> input)
        {
            List<_294_XCHECKHI> xCheckHis = new List<_294_XCHECKHI>();

            foreach (var row in input)
            {
                xCheckHis.Add(GetXCheckHis(row));
            }

            ChecksOutTemplate outTemplate = new ChecksOutTemplate()
            {
                _294_XCHECKHI = xCheckHis
            };

            return outTemplate;
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
    }
}