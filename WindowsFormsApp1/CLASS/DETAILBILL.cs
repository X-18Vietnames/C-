using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class DETAILBILL
    {
        public int IDBILL { get; set; }
        public int IDFOOD { get; set; }
        public int PRICEBILL { get; set; }
        public int NUMBER { get; set; }
        public int TOTALMONEY { get; set; }
        public DETAILBILL() { }
        public DETAILBILL( int IDBILL, int IDFOOD, int PRICEBILL, int NUMBER , int TOTALMONEY) 
        {
            this.IDBILL = IDBILL;this.IDFOOD = IDFOOD;
            this.PRICEBILL = PRICEBILL;this.NUMBER = NUMBER;this.TOTALMONEY = TOTALMONEY;     }
    }
}
