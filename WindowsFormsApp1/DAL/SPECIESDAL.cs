﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.CLASS;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.DAL
{
    class SPECIESDAL
    {
        public static DataTable GETSPECIES()
        {
            SqlConnection Conn = ketnoisql.ketnoi();
            SqlCommand command = new SqlCommand("VIEWSPECIES", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
