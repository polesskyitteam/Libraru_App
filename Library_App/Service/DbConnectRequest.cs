using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Library_App.Service
{
    class DbConnectRequest
    {

        public static SqlConnection db = new SqlConnection(@"Data Source=10.10.10.34;Initial Catalog=lyashevsky;Persist Security Info=True;User ID=Evgen;Password=6510033");
        public static SqlConnection get()
        {
            return db;
        }       
        public DataTable dbConnectRequest(string request)
        {            
            try
            {
                db.Open();
                string command = request;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command, db);
                da.Fill(dt);
                return dt;
            }            
            finally
            {
                db.Close();
            }
        }
    }
}
