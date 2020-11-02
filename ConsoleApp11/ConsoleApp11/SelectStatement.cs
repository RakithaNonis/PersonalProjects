using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class SelectStatement
    {
        public static List<Vehicle> arr = new List<Vehicle>();
        public static void Read()
        {
             
        string constr;

            // for the connection to  
            // sql server database 
            SqlConnection conn;

            // Data Source is the name of the  
            // server on which the database is stored. 
            // The Initial Catalog is used to specify 
            // the name of the database 
            // The UserID and Password are the credentials 
            // required to connect to the database. 

            //constr = @"Data Source=DESKTOP-GP8F496;Initial Catalog=Demodb;User ID=sa;Password=24518300";

            //conn = new SqlConnection(constr);
            string connString = Properties.Settings.Default.ConStr;
             conn = new SqlConnection(connString);
            // to open the connection 
            conn.Open();

            // use to perform read and write 
            // operations in the database 
            SqlCommand cmd;

            // use to read a row in 
            // table one by one 
            SqlDataReader dreader;

            // to sore SQL command and 
            // the output of SQL command 
            string sql, output = "";

            // use to fetch rwos from demo table 
            sql = "Select UserId, Brand,Owner,Price from demo";

            // to execute the sql statement 
            cmd = new SqlCommand(sql, conn);

            // fetch all the rows  
            // from the demo table 
            dreader = cmd.ExecuteReader();

            // for one by one reading row 
            
          
            while (dreader.Read())
            {

                //output = output + dreader.GetValue(0) + " - " +
                //                    dreader.GetValue(1) + " - " + dreader.GetValue(2) + " - "  + dreader.GetDecimal(3) + " - " + "\n";
                Vehicle v = new Vehicle();
                v.getUserId = dreader.GetInt32(0);
                v.getBrand = dreader.GetString(1);
                v.getOwner = dreader.GetString(2);
                v.getPrice = dreader.GetDecimal(3);

                if (v!=null)
                {

                }
            }

            // to display the output 
            Console.Write(output);

            // to close all the objects 
            dreader.Close();
            cmd.Dispose();
            conn.Close();
        }
    }
}
