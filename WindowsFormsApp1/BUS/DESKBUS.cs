﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.CLASS;

namespace WindowsFormsApp1.BUS
{
    class DESKBUS
    {
        public static DataTable GETDESK()
        {
            return DESKDAL.GetDesk();
        }
    }
}
