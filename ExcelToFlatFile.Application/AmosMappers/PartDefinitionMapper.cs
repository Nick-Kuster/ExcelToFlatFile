using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class PartDefinitionMapper : BaseMapper<PartTemplate, PartDefinitionOutTemplate>
    {
        public override PartDefinitionOutTemplate Map(List<PartTemplate> input)
        {
            List<_122_XROTABLE> xROTables = new List<_122_XROTABLE>();
            List<_407_XHISTORY> xHistories = new List<_407_XHISTORY>();
            
            foreach (var row in input)
            {
                xROTables.Add(GetXROTable(row));
                xHistories.Add(GetXHistory(row));
            }
            
            PartDefinitionOutTemplate outTemplate = new PartDefinitionOutTemplate()
            {
                _122_XROTABLE = xROTables,
                _407_XHISTORY = xHistories
            };

            return outTemplate;
        }

        private _407_XHISTORY GetXHistory(PartTemplate input)
        {
            var output = new _407_XHISTORY()
            {
                PARTNO = input.PART_NUMBER,
                SERIALNUMBER = input.SERIAL_NUMBER,
                RECEIVER =  input.Aircraft,
                TRANS_DATE = GetConditionalDate(input.DELIVERY_DATE, input.INSTALLATION_DATE, "MM/dd/yyyy"),
                TRANS_TYPE = "YE",
                TAH = input.TAH_INST.MultiplyStringByInt(60),
                TAC = input.TAC_INST,
                TSN = input.TSN.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60),
                TBI = "",
                CBI = "",
                CSN = input.CSN.SetToEmptyIfMatch("UNK"),
                CONDITION = input.CONDITION,
                REL_FLAG = "",
                CONFIRMED = "",
                BOOKED_BY = "",
                BOOKING_DATE = "",
                QTY = "",
                VOUCHERNO = "",
                ORDERNO = "",
                HI_TEXT_KEY = "",
                LABELNO = "",
                CUST_WO = "", 
                STATION = "",
                STORE = "",
                LOCATION = "",
                POSITION = input.Position,
                ORDERDATE = "",
                GIGHER_PARTNO = "",
                HIGHER_SERIALNO = "",
                UNIQUE_ROT_ID = "",
                MAT_CLASS = "",
                AVERAGE_PRICE = "",
                REPAIRABLE = "",
                MFG_DATE = "",
                BATCHNO = "",
                ATA_CHAPTER = "",
                ENTITY = "VXP",
                PROJECTNO = "",
                STATUS = "",
                CR_ISNEW = "",
                OWNER = ""
            };
            return output;
        }

        private _122_XROTABLE GetXROTable(PartTemplate input)
        {
            var output = new _122_XROTABLE()
            {
                PARTNO = input.PART_NUMBER,
                SERIALNO = input.SERIAL_NUMBER,
                OWNER = "VXP",
                DEL_DATE = GetConditionalDate(input.DELIVERY_DATE, input.INSTALLATION_DATE, "MM/dd/yyyy"),
                MFG_DATE = input.MFG_DATE.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("MM/dd/yyyy"),
                LABELNO = "",
                AIRCRAFT = input.Aircraft,
                POSITION = input.Position,
                STATION = "",
                STORE = "",
                LOCATION = "",
                ENTITY = "",
                READOUT_DATE = GetConditionalDate(input.INSTALLATION_DATE, input.DELIVERY_DATE, "MM/dd/yyyy"),
                TAH_INST = input.TAH_INST.MultiplyStringByInt(60),
                TAC_INST = input.TAC_INST,
                TSN = input.TSN.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60),
                CSN = input.CSN.SetToEmptyIfMatch("UNK"),
                CONDITION = input.CONDITION,
                LAST_OH_DATE = "",
                OH_DATE_UNK = "Y",
                LAST_OH_CYCLES = "",
                OH_CYCLES_UNK = "Y",
                LAST_OH_TSN = "",
                OH_TSN_UNK = "Y",
                LAST_REP_DATE = "",
                REP_DATE_UNK = "Y",
                LAST_REP_CYCLES = "",
                REP_CYCLES_UNK = "Y",
                LAST_REP_TSN = "",
                REP_TSN_UNK = "Y",
                LAST_MOD_DATE = "",
                MOD_DATE_UNK = "Y",
                LAST_MOD_CYCLES = "",
                MOD_CYCLES_UNK = "Y",
                LAST_MOD_TSN = "",
                MOD_TSN_UNK = "Y",
                OLD_LABELNO = "",
                TSN_UNKNOWN = string.IsNullOrEmpty(input.TSN) ? "Y" : "",
                CSN_UNKNOWN = string.IsNullOrEmpty(input.CSN) ? "Y" : "",
                MFG_UNKNOWN = string.IsNullOrEmpty(input.MFG_DATE) ? "Y" : ""
            };
            return output;
        }
        
        private string GetConditionalDate(string firstDate, string secondDate, string format)
        {
            var date = string.IsNullOrEmpty(firstDate) ? secondDate : firstDate;
            var formattedDate = date.ConvertToFormattedDateString(format);
            return formattedDate;
        }
    }
}