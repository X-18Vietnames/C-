using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class employer
    {
        public int IDEMPLOYER { get; set; }
        public string NAMEEMPLOYER { get; set; }
        public int NUMBERPHONE { get; set; }
        public string ADDRESS { get; set; }
        public int WAGES { get; set; }
        public employer() { }
        public employer( int IDEMPLOYER, string NAMEEMPLOYER, int NUMBERPHONE, string ADDRESS, int WAGES)
        {
            this.IDEMPLOYER = IDEMPLOYER; this.NAMEEMPLOYER = NAMEEMPLOYER; this.NUMBERPHONE = NUMBERPHONE;this.ADDRESS = ADDRESS; this.WAGES = WAGES;
        }
    }
}
