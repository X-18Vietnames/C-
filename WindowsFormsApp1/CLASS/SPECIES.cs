using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.CLASS
{
    class SPECIES
    {    
        public int IDSPECIES { get; set; }
        public string NAMESPECIES { get; set; }
        public SPECIES() { }
        public SPECIES (int IDSPECIES, string NAMESPECIES)
        {
            this.IDSPECIES = IDSPECIES;
            this.NAMESPECIES = NAMESPECIES;
        }

    }
}
