using System.Collections.Generic;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Checks;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class CheckMapper : BaseMapper<ChecksTemplate, _CHECKS_OUT_TEMPLATE>
    {
        public override _CHECKS_OUT_TEMPLATE Map(List<ChecksTemplate> input)
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

            _CHECKS_OUT_TEMPLATE outTemplate = new _CHECKS_OUT_TEMPLATE()
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
                EffTitle = row.EffTitle,
                EffTitlePar = "",
                EffTitleHigh = "",
                AcType = "", // ?
                AcModel = "", // ?
                AcSub = null, // ?
                EffAcType = "",
                PartNo = "",
                SerType = "", // ?
                Changeable = "", // ?
                Description = ""
            };

            return output;
        }
        private _119_XEFFSER GetXEffSer(ChecksTemplate row)
        {
            var output = new _119_XEFFSER
            {
                EffTitle = row.EffTitle,
                RangeType = "", // ?
                SerialNoFrom = "", // ?
                SerialNoTo = "", // ?
                InclExcl = "", // ?
                SerShift = "" 
            };

            return output;
        }
        private _281_XCHECKTY GetXCheckTy(ChecksTemplate row)
        {
            var output = new _281_XCHECKTY
            {
                CheckType = row.CheckType,
                Description = "", // ?
                DefaultStation = "",
                NbrOfInternalChecks = "", // ?
                HasLimit = "", // ?
                LetterCheck = "", // ?
                Compliance = "", // ?
                Category = ""
            };
            return output;
        }
        private _282_XCHECKEFFLINK GetXCheckEffLink(ChecksTemplate row)
        {
            var output = new _282_XCHECKEFFLINK
            {
                CheckType = row.CheckType,
                EffTitle = row.EffTitle
            };

            return output;
        }
        private _284_XCHECKEFFTREQ GetXCheckEffTReq(ChecksTemplate row)
        {
            var output = new _284_XCHECKEFFTREQ
            {
                CheckType = row.CheckType,
                InternalCheck = "", // ?
                EffTitle = row.EffTitle,
                DimType = "", // ?
                Fl = "", // ?
                Dim = "", // ?
                Amount = "", // ?
                ThrBase = "",
                ThrBaseDim = "",
                ThrBaseAmount = "",
                Unlimited = "", // ?
                Terminating = "", // ?
                CalcStrat = "", // ?
                AutoRepBack = ""
            };

            return output;
        }
        private _285_XCHECKEFFWT GetXCheckEffWT(ChecksTemplate row)
        {
            var output = new _285_XCHECKEFFWT
            {
                CheckType = row.CheckType,
                InternalCheck = row.CheckType,
                EffTitle = row.EffTitle,
                Revision = "", // ?
                AtaChapter = "", // ?
                EventClass = "",
                DefectClass = "",
                Prio = "",
                ProjectNo = ""
            };

            return output;
        }
        private _287_XCHECKEFFWS GetXCheckEffWS(ChecksTemplate row)
        {
            var output = new _287_XCHECKEFFWS
            {
                CheckType = row.CheckType,
                InternalCheck = row.CheckType,
                EffTitle = row.EffTitle,
                SeqNo = "", // ?
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
                RevStatus = "", // ?
                Text = "", // ?
                Comment = ""
            };

            return output;
        }
        private _294_XCHECKHI GetXCheckHis(ChecksTemplate row)
        {
            var output = new _294_XCHECKHI()
            {
                CheckType = row.CheckType,
                InternalCheck = row.CheckType,
                EffTitle = row.EffTitle,
                Aircraft = row.Aircraft,
                PerfTah = row.PerfTah,
                PerfTac = row.PerfTac,
                PerfDate = row.PerfDate,
                ControlDim1 = "",
                DueAmount1 = "",
                PerfAmount1 = "",
                ControlDim2 = "",
                DueAmount2 = "",
                PerfAmount2 = "",
                ControlDim3 = "",
                DueAmount3 = "",
                PerfAmount3 = "",
                PerfCustomerWo = "",
                EventIdentifier = ""
            };

            return output;
        }
        private _295_XCHECKPE GetXCheckPE(ChecksTemplate row)
        {
            var output = new _295_XCHECKPE
            {
                CheckType = row.CheckType,
                InternalCheck = "", // ?
                EffTitle = row.EffTitle,
                Aircraft = row.Aircraft,
                NeverPerformed = row.NeverPerformed,
                ControlDim1 = "",  // ?
                DueAmount1 = "",  // ?
                ControlDim2 = "",  // ?
                DueAmount2 = "",  // ?
                ControlDim3 = "",  // ?
                DueAmount3 = "",  // ?
                EventIdentifier = "" 
            };

            return output;
        }
    }
}