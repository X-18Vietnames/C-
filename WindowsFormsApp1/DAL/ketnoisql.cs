using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace WindowsFormsApp1.DAL
{
   public class ketnoisql

    {
        public static  SqlConnection ketnoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-JUDQI9TS;Initial Catalog=COFFE_MANAGEMENT;Integrated Security=True");
                return conn;
        }
    }
}
