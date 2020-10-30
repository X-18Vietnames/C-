using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.CLASS;
using System.Data;

namespace WindowsFormsApp1.BUS
{
    class FOODBUS
    {

        public static DataTable GETFOOD()
        {
            return FOODDAL.GETFOOD();
        }
    }
}
