using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class FOOD
    {
        public int IDFOOD { get; set; }
        public string NAMEFOOD { get; set; }
        public int IDSPECIES { get; set; }
        public int PRICE { get; set; }
        public FOOD() { }
        public FOOD(int IDFOOD, string NAMEFOOD, int IDSPECIES, int PRICE) {
            this.IDFOOD = IDFOOD; this.NAMEFOOD = NAMEFOOD;this.IDSPECIES = IDSPECIES;this.PRICE = PRICE;
        }
    }
}
