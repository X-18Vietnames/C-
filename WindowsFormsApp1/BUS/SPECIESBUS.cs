using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.CLASS;
using WindowsFormsApp1.DAL;
using System.Data;

namespace WindowsFormsApp1.BUS
{
    class SPECIESBUS
    {

        public static DataTable GETSPECIES()
        {
            return SPECIESDAL.GETSPECIES();
        }
    }
}
