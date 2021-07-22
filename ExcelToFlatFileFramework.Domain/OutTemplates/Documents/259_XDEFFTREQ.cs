using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelToFlatFileFramework.Domain.Attributes;

namespace ExcelToFlatFileFramework.Domain.OutTemplates.Documents
{
    public class _259_XDEFFTREQ
    {
        [AmosOutputLength(25)]        
        public string DOCNO { get; set; }
        [AmosOutputLength(6)]        
        public string DOC_TYPE { get; set; }
        [AmosOutputLength(4)]        
        public string REVISION { get; set; }
        [AmosOutputLength(12)]        
        public string ISSUED_BY { get; set; }
        [AmosOutputLength(70)]        
        public string EFF_TITLE { get; set; }
        [AmosOutputLength(1)]        
        public string DIM_TYPE { get; set; }
        [AmosOutputLength(1)]        
        public string THR_BASE { get; set; }
        [AmosOutputLength(1)]        
        public string FL { get; set; }
        [AmosOutputLength(20)]        
        public string DIM_GROUP { get; set; }
        [AmosOutputLength(2)]        
        public string DIM { get; set; }
        [AmosOutputLength(10)]        
        public string AMOUNT { get; set; }
        [AmosOutputLength(2)]        
        public string THR_BASE_DIM { get; set; }
        [AmosOutputLength(10)]        
        public string THR_BASE_AMOUNT { get; set; }
        [AmosOutputLength(1)]        
        public string UNLIMITED { get; set; }
        [AmosOutputLength(1)]        
        public string TERMINATING { get; set; }
        [AmosOutputLength(4)]        
        public string CALC_STRAT { get; set; }
        [AmosOutputLength(1)]        
        public string AUTO_REP_BACK { get; set; }

    }
}
