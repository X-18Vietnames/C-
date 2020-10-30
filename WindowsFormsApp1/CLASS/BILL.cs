using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class BILL
    {
     public int   IDBILL { get; set; }
     public DateTime DATEBILL { get; set; }
    public int   IDEMPLOYER { get; set; }
    public int SUMBILL { get; set; }
    public int IDDESK { get; set;     }

    public BILL() { }
        public BILL(int idbill, DateTime datebill, int idemployer, int sumbill, int iddesk)
        {
            this.IDBILL = idbill;
            this.DATEBILL = datebill;
            this.IDEMPLOYER = idemployer;this.SUMBILL = sumbill;
            this.IDDESK = iddesk;
        
        }
    }
}
