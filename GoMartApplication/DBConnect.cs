using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GoMartApplication
{
    class DBConnect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I69OQPV\SQLEXPRESS;Initial Catalog=GoMartDB;Integrated Security=True");
        public SqlConnection GetCon()
        {
            return con;
        }
        public void OpenCon()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseCon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
