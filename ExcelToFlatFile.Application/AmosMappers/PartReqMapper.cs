using System;
using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartReq;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class PartReqMapper : BaseMapper<PartTemplate, PartReqOutTemplate>
    {
        public override PartReqOutTemplate Map(List<PartTemplate> input)
        {
            List<_148_XPARTREQHI> xPartReqHiList = new List<_148_XPARTREQHI>();
            List<_149_XPARTREQPE> xPartReqPEList = new List<_149_XPARTREQPE>();
            
            foreach (var row in input)
            {
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
            
            PartReqOutTemplate outTemplate = new PartReqOutTemplate()
            {
                _148_XPARTREQHI = xPartReqHiList,
                _149_XPARTREQPE = xPartReqPEList
            };

            return outTemplate;
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