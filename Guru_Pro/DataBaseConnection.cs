using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Guru_Pro
{
    public static class DataBaseConnection
    {
         
        

        public static SqlConnection Connection()
        {
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vimukthi Gunasekara\Desktop\Guru Project\Guru_Pro\Guru_Pro\Database1.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;

            //
        }
        // DataBase Connection eka hadanakota mulinama database package eka daganna one.ita passe connecting wede karapan.
    }
}
