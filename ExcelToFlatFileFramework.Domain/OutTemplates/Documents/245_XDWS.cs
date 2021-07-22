using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _245_XDWS
    {
        [AmosOutputLength(25)]        
        public string DocNo { get; set; }
        [AmosOutputLength(6)]        
        public string DocType { get; set; }
        [AmosOutputLength(4)]        
        public string Revision { get; set; }
        [AmosOutputLength(12)]        
        public string IssuedBy { get; set; }
        [AmosOutputLength(4)]        
        public string SeqNo { get; set; }
        [AmosOutputLength(1)]        
        public string WsType { get; set; }
        [AmosOutputLength(70)]        
        public string Header { get; set; }
        [AmosOutputLength(8)]        
        public string Sign { get; set; }
        [AmosOutputLength(1)]        
        public string Critical { get; set; }
        [AmosOutputLength(1)]        
        public string Defuel { get; set; }
        [AmosOutputLength(1)]        
        public string DoubleInsp { get; set; }
        [AmosOutputLength(1)]        
        public string ElPower { get; set; }
        [AmosOutputLength(1)]        
        public string EventOpen { get; set; }
        [AmosOutputLength(1)]        
        public string Ewis { get; set; }
        [AmosOutputLength(1)]        
        public string ExtHydr { get; set; }
        [AmosOutputLength(1)]        
        public string HydrOff { get; set; }
        [AmosOutputLength(1)]        
        public string IdleRun { get; set; }
        [AmosOutputLength(1)]        
        public string Insurance { get; set; }
        [AmosOutputLength(1)]        
        public string Ndt { get; set; }
        [AmosOutputLength(1)]        
        public string PowerRun { get; set; }
        [AmosOutputLength(1)]        
        public string TankEntry { get; set; }
        [AmosOutputLength(1)]        
        public string TestFlight { get; set; }
        [AmosOutputLength(1)]        
        public string Troubleshooting { get; set; }
        [AmosOutputLength(1)]        
        public string Warranty { get; set; }
        [AmosOutputLength(1)]        
        public string Etops { get; set; }
        [AmosOutputLength(1)]        
        public string Ad { get; set; }
        [AmosOutputLength(15)]        
        public string Phase { get; set; }
        [AmosOutputLength(4)]        
        public string WsRev { get; set; }
        [AmosOutputLength(1)]        
        public string RevStatus { get; set; }
        [AmosOutputLength(1500)]        
        public string Text { get; set; }
        [AmosOutputLength(1000)]        
        public string Comment { get; set; }
    }
}
