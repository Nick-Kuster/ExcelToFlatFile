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
            // List<_068_XPART> _068_XPART = new List<_068_XPART>();
            // List<_072_XPARTFAENTITY> _072_XPARTFAENTITY = new List<_072_XPARTFAENTITY>();
            // List<_075_XPARTACT> _075_XPARTACT = new List<_075_XPARTACT>();
            // List<_076_XPARTPOS> _076_XPARTPOS = new List<_076_XPARTPOS>();
            // List<_082_XPARTWT> _082_XPARTWT = new List<_082_XPARTWT>();
            // List<_084_XPARTWS> _084_XPARTWS = new List<_084_XPARTWS>();
            List<_122_XROTABLE> xROTables = new List<_122_XROTABLE>();
            List<_407_XHISTORY> xHistories = new List<_407_XHISTORY>();
            
            foreach (var row in input)
            {
                // _068_XPART.Add(GetXPART(row));
                // _072_XPARTFAENTITY.Add(GetXPARTFAENTITY(row));
                // _075_XPARTACT.Add(GetXPARTACT(row));
                // _076_XPARTPOS.Add(GetXPARTPOS(row));
                // _082_XPARTWT.Add(GetXPARTWT(row));
                // _084_XPARTWS.Add(GetXPARTWS(row));
                xROTables.Add(GetXROTable(row));
                xHistories.Add(GetXHistory(row));
            }
            
            PartDefinitionOutTemplate outTemplate = new PartDefinitionOutTemplate()
            {
                // _068_XPART = _068_XPART,
                // _072_XPARTFAENTITY = _072_XPARTFAENTITY,
                // _075_XPARTACT = _075_XPARTACT,
                // _076_XPARTPOS = _076_XPARTPOS,
                // _082_XPARTWT = _082_XPARTWT,
                // _084_XPARTWS = _084_XPARTWS,
                _122_XROTABLE = xROTables,
                _407_XHISTORY = xHistories
            };

            return outTemplate;
        }
        private _068_XPART GetXPART(PartTemplate row)
        {
            var output = new _068_XPART
            {
                PARTNO = row.PART_NUMBER,
                Description = row.DESCRIPTION,
                ATA_CHAPTER = row.ATA,
                MATERIAL_CLASS = row.MATERIAL_CLASS,
                FA_AC_TYPE = "737",
                ADDRESS = "",
                STORETIME = "",
                WEIGHT = "",
                ALERT_QTY = "",
                REORDER_LEVEL = "",
                MAX_PURCH_QTY = "",
                MEASURE_UNIT = row.MEASURE_UNIT,
                TOOL = "",
                REPAIRABLE = row.REPAIRABLE,
                SIZE = "",
                DOCUMENT_REF = "",
                REMARKS = "",
                DEFAULT_SUPPLIER = "",
                DEFAULT_REPAIR = "",
                MANUFACTURER = "",
                REORDER_MODEL = "",
                STATUS = "",
                ATA200_CONVERT = "",
                MAT_TYPE = row.MAT_TYPE,
                FIXED_ASSET = "",
                ORIGIN = "",
                MAX_SHOP_VISIT = "",
                SW_RESET_COND = "",
                SPECIFICATIONS = "",
                EXT_STATE = "",
                SAFETY_STOCK = "",
                PMA = "",
                SPECIAL_MEASURE_UN = "",
                RESOURCE_TYPE = ""
            };
            return output;
        }
        private _072_XPARTFAENTITY GetXPARTFAENTITY(PartTemplate row)
        {
            var output = new _072_XPARTFAENTITY
            {
                PARTNO = row.PART_NUMBER,
                ENTITY = "VXP"
            };
            return output;
        }
        private _075_XPARTACT GetXPARTACT(PartTemplate row)
        {
            var output = new _075_XPARTACT
            {
                PARTNO = row.PART_NUMBER,
                IPC_REFERENCE = "",
                AC_TYPE = "737"
            };
            return output;
        }
        private _076_XPARTPOS GetXPARTPOS(PartTemplate row)
        {
            // Don't understand the "Note" on this one.
            var output = new _076_XPARTPOS
            {
                PARTNO = row.PART_NUMBER,
                AC_TYPE = "737",
                POSITION = row.Position,
                ATA_CHAPTER = row.ATA
            }; 
            return output;
        }
        private _082_XPARTWT GetXPARTWT(PartTemplate row)
        {
            var output = new _082_XPARTWT
            {
                PARTNO = row.PART_NUMBER,
                REVISION = "",
                ATA_CHAPTER = row.ATA
            };
            return output;
        }
        private _084_XPARTWS GetXPARTWS(PartTemplate row)
        {
            var output = new _084_XPARTWS
            {
                PARTNO = row.PART_NUMBER,
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
                HYRD_OFF = "",
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
                REV_STATUS = "1",
                TEXT = row.DESCRIPTION,
                COMMENT = ""
            }; 
            return output;
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