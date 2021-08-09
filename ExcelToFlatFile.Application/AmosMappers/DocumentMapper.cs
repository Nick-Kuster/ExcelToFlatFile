using System.Collections.Generic;
using System.ComponentModel;
using ExcelToFlatFile.Application.Extensions;
using ExcelToFlatFileFramework.Domain.InTemplates;
using ExcelToFlatFileFramework.Domain.OutTemplates.Documents;

namespace ExcelToFlatFile.Application.AmosMappers
{
    public class DocumentMapper : BaseMapper<DocumentTemplate, _DOCUMENT_OUT_TEMPLATE>
    {
        public override _DOCUMENT_OUT_TEMPLATE Map(List<DocumentTemplate> input)
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
            List<_XDSOFF> XDSOFF = new List<_XDSOFF>();

            foreach (var row in input)
            {
                // _118_XEFF.Add(GetXEFF(row));
                // _119_XEFFSER.Add(GetXEFFSER(row));
                // _240_XDHE.Add(GetXDHE(row));
                // // ONLY documents with "AC-OR-COMP" =  "C" gets an entry in this file (241)
                //if (row.AC_OR_COMP == "C")
                //{
                //    _241_XDCOMPACTYPE.Add(GetXDCOMPACTYPE(row));
                //}
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

            _DOCUMENT_OUT_TEMPLATE outTemplate = new _DOCUMENT_OUT_TEMPLATE()
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
                EffTitle = row.EFF_TITLE,
                EffTitlePar = "",
                EffTitleHigh = "",
                AcType = row.AC_TYPE,
                AcModel = row.AC_MODEL,
                AcSub = row.AC_SUB,
                EffAcType = "",
                PartNo = row.PartNo,
                SerType = "", // ?
                Changeable = "", // ?
                Description = "" // ?
            };

            return output;
        }
        private _119_XEFFSER GetXEFFSER(DocumentTemplate row)
        {
            var output = new _119_XEFFSER
            {
                EffTitle = row.EFF_TITLE,
                RangeType = "", // ?
                SerialNoFrom = "", // ?
                SerialNoTo = "", // ?
                InclExcl = "", // ?
                SerShift = ""
            };

            return output;
        }
        private _240_XDHE GetXDHE(DocumentTemplate row)
        {
            var output = new _240_XDHE
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                AcOrComp = row.AC_OR_COMP,
                AtaChapter = row.ATA_CHAPTER,
                Compliance = "?",
                Text1 = row.TEXT1,
                Text2 = row.TEXT2,
                RevDate = row.REV_DATE,
                IssueDate = row.ISSUE_DATE,
                RecDate = "",
                TimeLimit = row.TIME_LIMIT,
                Repetitive = row.REPETITIVE,
                EstGroundTime = "",
                EffectiveDate = row.EFFECTIVE_DATE,
                OpsAffected = "",
                SimAffected = "",
                RemovalReq = "",
                ShopOrLine = "",
                ControlledBy = "",
                TypeOfChange = "",
                WarrantyLabour = "",
                WarrantyMat = "",
                EstMhDoc = "",
                OrgDocNo = "",
                OrgDocType = "",
                LabourCost = "",
                MatCost = "",
                ModCampaign = "",
                ModAttrition = "",
                CostCenter = "",
                CostType = "",
                ReleaseState = "",
                Inspection = "",
                AssessResp = "",
                AssessStart = "",
                AssessEnd = "",
                GrndOpsAff = "",
                TrialInst = "",
                Occasion = "",
                Uuid = "",
                ImpNotes = ""
            }; 
            return output;
        }
        private _241_XDCOMPACTYPE GetXDCOMPACTYPE(DocumentTemplate row)
        {
            // ONLY documents with "AC-OR-COMP" =  "C" gets an entry in this file
            var output = new _241_XDCOMPACTYPE
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                AcType = "737"
            }; 
            return output;
        }
        private _243_XDHETX GetXDHETX(DocumentTemplate row)
        {
            var output = new _243_XDHETX
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                Text = row.TEXT1
            };
            return output;
        }
        
        private _245_XDWS GetXDWS(DocumentTemplate row)
        {
            var output = new _245_XDWS
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                SeqNo = "?",
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
                WsRev = "",
                RevStatus = "", // ?
                Text = $"{row.TEXT} {row.TEXT1} {row.TEXT2}",
                Comment = ""
            };
            return output;
        }
        private _247_XDHECT GetXDHECT(DocumentTemplate row)
        {
            var output = new _247_XDHECT
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                Text = row.TEXT1
            };
            return output;
        }
        private _255_XDEFFLINK GetXDEFFLINK(DocumentTemplate row)
        {
            var output = new _255_XDEFFLINK
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
                AutoStatus = "",
                NextShopVis = "",
                PrintRel0Cert = ""
            }; 
            return output;
        }
        private _259_XDEFFTREQ GetXDEFFTREQ(DocumentTemplate row)
        {
            var output = new _259_XDEFFTREQ
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
                DimType = "", // ?
                ThrBase = "",// ?
                Fl = "", // ?
                DimGroup = "",
                Dim = "", // ?
                Amount = "", // ?
                ThrBaseDim = "",
                ThrBaseAmount = "",
                Unlimited = row.UNLIMITED,
                Terminating = "", // ?
                CalcStrat = "", // ?
                AutoRepBack = ""
            }; return output;
        }

        private _260_XDEFFWT GetXDEFFWT(DocumentTemplate row)
        {
            var output = new _260_XDEFFWT
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
                WtRevision = "",
                AtaChapter = row.ATA_CHAPTER,
                EventClass = "",
                DefectClass = "",
                Prio = "",
                ProjectNo = ""
            };
            return output;
        }
        private _262_XDEFFWS GetXDEFFWS(DocumentTemplate row)
        {
            var output = new _262_XDEFFWS
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
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
                WsRev = "",
                RevStatus = "", // ?
                Text = $"{row.TEXT} {row.TEXT1} {row.TEXT2}",
                Comment = ""
            }; return output;
        }
        
        private _268_XDHIST GetXDHist(DocumentTemplate row)
        {
            _268_XDHIST output = new _268_XDHIST()
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
                AcRegistr = row.AC_REGISTR,
                PartNo = row.PartNo,
                SerialNumber = row.SerialNumber,
                PerfHours = row.PERF_HOURS.MultiplyStringByInt(60),
                PerfCycles = row.PERF_CYCLES,
                PerfDate = row.PERF_DATE.ConvertToFormattedDateString("dd.MM.yyyy"),
                Dim1 = "",
                DueAmount1 = "",
                PerfAmount1 = "",
                Dim2 = "",
                DueAmount2 = "",
                PerfAmount2 = "",
                Dim3 = "",
                DueAmount3 = "",
                PerfAmount3 = "",
                PerfStatus = row.STATUS,
                PartlyPerf = "N",
                PerfRefDoc = "",
                PerfCustomerWo = "",
                UniqueRotId = "",
                IsLastHistory = "Y",
                EventIdentifier = "",
                PerfText = ""
            };

            return output;
        }
        private _269_XDPEND GetXDPends(DocumentTemplate row)
        {
            _269_XDPEND output = new _269_XDPEND()
            {
                DocNo = row.DOCNO,
                DocType = row.DOC_TYPE,
                Revision = row.REVISION,
                IssuedBy = row.ISSUED_BY,
                EffTitle = row.EFF_TITLE,
                AcRegistr = row.AC_REGISTR,
                PartNo = row.PartNo,
                SerialNumber = row.SerialNumber,
                OpenStatus = row.STATUS,
                DueCustomerWo = "",
                EventIdentifier = ""
            };
            FillDueDIMLogic(output, row);
            return output;
        }
        private _XDSOFF GetXDSOFF(DocumentTemplate row)
        {
            var output = new _XDSOFF
            {
                Docno1 = row.DOCNO,
                DocType1 = row.DOC_TYPE,
                Revision1 = row.REVISION,
                IssuedBy1 = row.ISSUED_BY,
                Docno2 = row.DOCNO,
                DocType2 = row.DOC_TYPE,
                Revision2 = row.REVISION,
                IssuedBy2 = row.ISSUED_BY
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
                output.DueDim1 = dimensionList[0];
                output.DueAmount1 = dueList[0];
            }
            if (dueList.Count >= 2)
            {
                output.DueDim2 = dimensionList[1];
                output.DueAmount2 = dueList[1];
            }
            if (dueList.Count >= 3)
            {
                output.DueDim3 = dimensionList[2];
                output.DueAmount3 = dueList[2];
            }
        }
    }
}