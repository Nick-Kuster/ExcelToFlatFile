using System.Collections.Generic;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.PartDefinition;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class PartDefinitionMapper : BaseMapper<PartTemplate, _PART_DEFINITION_OUT_TEMPLATE>
    {
        public override _PART_DEFINITION_OUT_TEMPLATE Map(List<PartTemplate> input)
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
            
            _PART_DEFINITION_OUT_TEMPLATE outTemplate = new _PART_DEFINITION_OUT_TEMPLATE()
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
                PartNo = row.PART_NUMBER,
                Description = row.DESCRIPTION,
                AtaChapter = row.ATA,
                MaterialClass = row.MATERIAL_CLASS,
                FaAcType = "737",
                Address = "",
                StoreTime = "",
                Weight = "",
                AlertQty = "",
                ReorderLevel = "",
                MaxPurchQty = "",
                MeasureUnit = row.MEASURE_UNIT,
                Tool = "",
                Repairable = row.REPAIRABLE,
                Size = "",
                DocumentRef = "",
                Remarks = "",
                DefaultSupplier = "",
                DefaultRepair = "",
                Manufacturer = "",
                ReorderModel = "",
                Status = "",
                Ata200Convert = "",
                MatType = row.MAT_TYPE,
                FixedAsset = "",
                Origin = "",
                MaxShopVisit = "",
                SwResetCond = "",
                Specifications = "",
                ExtState = "",
                SafetyStock = "",
                Pma = "",
                SpecialMeasureUn = "",
                ResourceType = ""
            };
            return output;
        }
        private _072_XPARTFAENTITY GetXPARTFAENTITY(PartTemplate row)
        {
            var output = new _072_XPARTFAENTITY
            {
                PartNo = row.PART_NUMBER,
                Entity = "VXP"
            };
            return output;
        }
        private _075_XPARTACT GetXPARTACT(PartTemplate row)
        {
            var output = new _075_XPARTACT
            {
                PartNo = row.PART_NUMBER,
                IpcReference = "",
                AcType = "737"
            };
            return output;
        }
        private _076_XPARTPOS GetXPARTPOS(PartTemplate row)
        {
            // Don't understand the "Note" on this one.
            var output = new _076_XPARTPOS
            {
                PartNo = row.PART_NUMBER,
                AcType = "737",
                Position = row.Position,
                AtaChapter = row.ATA
            }; 
            return output;
        }
        private _082_XPARTWT GetXPARTWT(PartTemplate row)
        {
            var output = new _082_XPARTWT
            {
                PartNo = row.PART_NUMBER,
                Revision = "",
                AtaChapter = row.ATA
            };
            return output;
        }
        private _084_XPARTWS GetXPARTWS(PartTemplate row)
        {
            var output = new _084_XPARTWS
            {
                PartNo = row.PART_NUMBER,
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
                HyrdOff = "",
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
                RevStatus = "1",
                Text = row.DESCRIPTION,
                Comment = ""
            }; 
            return output;
        }

        private _407_XHISTORY GetXHistory(PartTemplate input)
        {
            var output = new _407_XHISTORY()
            {
                PartNo = input.PART_NUMBER,
                SerialNumber = input.SERIAL_NUMBER,
                Receiver =  input.Aircraft,
                TransDate = GetConditionalDate(input.DELIVERY_DATE, input.INSTALLATION_DATE, "MM/dd/yyyy"),
                TransType = "YE",
                Tah = input.TAH_INST.MultiplyStringByInt(60),
                Tac = input.TAC_INST,
                Tsn = input.TSN.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60),
                Tbi = "",
                Cbi = "",
                Csn = input.CSN.SetToEmptyIfMatch("UNK"),
                Condition = input.CONDITION,
                RelFlag = "",
                Confirmed = "",
                BookedBy = "",
                BookingDate = "",
                Qty = "",
                VoucherNo = "",
                OrderNo = "",
                HiTextKey = "",
                LabelNo = "",
                CustWo = "", 
                Station = "",
                Store = "",
                Location = "",
                Position = input.Position,
                OrderDate = "",
                GigherPartNo = "",
                HigherSerialNo = "",
                UniqueRotId = "",
                MatClass = "",
                AveragePrice = "",
                Repairable = "",
                MfgDate = "",
                BatchNo = "",
                AtaChapter = "",
                Entity = "VXP",
                ProjectNo = "",
                Status = "",
                CrIsNew = "",
                Owner = ""
            };
            return output;
        }

        private _122_XROTABLE GetXROTable(PartTemplate input)
        {
            var output = new _122_XROTABLE()
            {
                PartNo = input.PART_NUMBER,
                SerialNo = input.SERIAL_NUMBER,
                Owner = "VXP",
                DelDate = GetConditionalDate(input.DELIVERY_DATE, input.INSTALLATION_DATE, "MM/dd/yyyy"),
                MfgDate = input.MFG_DATE.SetToEmptyIfMatch("UNK").ConvertToFormattedDateString("MM/dd/yyyy"),
                LabelNo = "",
                Aircraft = input.Aircraft,
                Position = input.Position,
                Station = "",
                Store = "",
                Location = "",
                Entity = "",
                ReadoutDate = GetConditionalDate(input.INSTALLATION_DATE, input.DELIVERY_DATE, "MM/dd/yyyy"),
                TahInst = input.TAH_INST.MultiplyStringByInt(60),
                TacInst = input.TAC_INST,
                Tsn = input.TSN.SetToEmptyIfMatch("UNK").MultiplyStringByInt(60),
                Csn = input.CSN.SetToEmptyIfMatch("UNK"),
                Condition = input.CONDITION,
                LastOhDate = "",
                OhDateUnk = "Y",
                LastOhCycles = "",
                OhCyclesUnk = "Y",
                LastOhTsn = "",
                OhTsnUnk = "Y",
                LastRepDate = "",
                RepDateUnk = "Y",
                LastRepCycles = "",
                RepCyclesUnk = "Y",
                LastRepTsn = "",
                RepTsnUnk = "Y",
                LastModDate = "",
                ModDateUnk = "Y",
                LastModCycles = "",
                ModCyclesUnk = "Y",
                LastModTsn = "",
                ModTsnUnk = "Y",
                OldLabelNo = "",
                TsnUnknown = string.IsNullOrEmpty(input.TSN) ? "Y" : "",
                CsnUnknown = string.IsNullOrEmpty(input.CSN) ? "Y" : "",
                MfgUnknown = string.IsNullOrEmpty(input.MFG_DATE) ? "Y" : ""
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