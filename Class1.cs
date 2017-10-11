using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Guru_Pro
{
    class Class1
    {
        public void addCustomer(int Id, string name, string Catagory, string BuyPrice, string SellPrice, string Discription)
        {
            string addCus = @"INSERT INTO ItemRegistationTable VALUES ('" + Id + "','" + name + "','" + Catagory + "','" + BuyPrice + "','" + SellPrice + "','" + Discription + "')";
            SqlCommand cmd = new SqlCommand(addCus, DataBaseConnection.Connection());
            cmd.ExecuteNonQuery();
        }
    }
}
