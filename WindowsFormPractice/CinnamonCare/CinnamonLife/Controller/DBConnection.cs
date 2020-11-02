using CinnamonLife.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonLife.Controller
{
    class DBConnection
    {
        public ComboBox selVehicle;
         
        public DBConnection(ComboBox selVehicle_) 
        {
            selVehicle = selVehicle_;
        }
        public DBConnection()
        {
          
        }
       
        public void selectType() 
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<VehicleType> vehicleList = new List<VehicleType>();
        
            SqlCommand cmd;
            string qry = "select TypeId,Type FROM VehicleType";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                VehicleType vehTyObj = new VehicleType(DR.GetInt32(0),DR.GetString(1));
                vehTyObj.GetvehicleId = DR.GetInt32(0);
                vehTyObj.GetvehicleType = DR.GetString(1);
                vehicleList.Add(vehTyObj);
            }
            
            selVehicle.DataSource = vehicleList;
            selVehicle.DisplayMember = "GetvehicleType";
          
        }
        public void AddingVehicle(AddVehicle x)
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            DateTime Gdate = time; 
          

            SqlCommand cmd;
            string sql = "INSERT INTO VehicleDetails (RegistrationNum,Brand,Owner,Price,TypeId) VALUES (@registrationnumber,@brand,@Owner,@price,@typeId)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@registrationnumber",x.AddResNumber);
            cmd.Parameters.AddWithValue("@brand", x.AddBrandName);
            cmd.Parameters.AddWithValue("@Owner", x.AddOwnerName);
            cmd.Parameters.AddWithValue("@price", x.AddPrice);
            cmd.Parameters.AddWithValue("@typeId", x.AddVehicleId);
            cmd.ExecuteNonQuery();
        }
    }
}
 