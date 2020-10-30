using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class DESK
    {
        public int IDDESK { get; set; }
        public string NAMEDESK { get; set; }
    public DESK() { }
        public DESK(int IDDESK,string NAMEDESK)
        {
            this.IDDESK = IDDESK;
            this.NAMEDESK = NAMEDESK;
        }

    }
}
