using CoronaCareApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCareApp.Controller
{
    class DBConnection
    {
        public static string cusPhone;
        
        
        public static void AddCustomer() 
        {
            Guest customer = new Guest();

            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            cusPhone = View.Login.GPhoneNumber;
            customer.getGphone = cusPhone;

            SqlCommand cmd;
            string qry = "INSERT INTO SampeGuest (Phone) VALUES (@cusPhone)";
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@cusPhone",customer.getGphone);
            cmd.ExecuteNonQuery();

            
        }
      

    }
}
