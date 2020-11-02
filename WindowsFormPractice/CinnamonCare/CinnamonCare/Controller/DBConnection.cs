using CinnamonCare.Model;
using CinnamonCare.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonCare.Controller
{
    class DBConnection
    {
        public static string gPhone;
        private static string gTable;
        private static string gHotel;
        private static string gTitle;
        private static string gName;
        private static string gCountry;
        private static decimal gTemperature;
        //private static   gArrivalDate;
        private static string upCus;
        private static string upPhn;


        public static string cusPhone;
        public static string cusTable;
        public static string cusName;
        public static decimal cusTemp;

     

        public DBConnection() { }
        public DBConnection(string upd) 
        {
            upCus = upd;
        }


        public DBConnection(string Gphn, string Gtbl, string Ghtl, string ttl, string nam, string ctry, decimal temp)
        {
            gPhone = Gphn;
            gTable = Gtbl;
            gHotel = Ghtl;
            gTitle = ttl;
            gName = nam;
            gCountry = ctry;
            gTemperature = temp;
        }
        

        public static List<string> Login()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<string> hotelslist = new List<string>();


            SqlCommand cmd;
            string qry = "select HotelName FROM Hotel";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                hotelslist.Add(DR.GetString(0));

            }

            return hotelslist;
        }
        public static List<string> GuestTitile()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<string> Titlelist = new List<string>();


            SqlCommand cmd;
            string qry = "select TitleDescription FROM GuestTitle";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                Titlelist.Add(DR.GetString(0));

            }

            return Titlelist;
        }
        public static List<string> GuestCountry()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<string> Countrylist = new List<string>();


            SqlCommand cmd;
            string qry = "select CountryName FROM Country";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                Countrylist.Add(DR.GetString(0));

            }

            return Countrylist;
        }

        public static List<string> Symtoms()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<string> symlist = new List<string>();


            SqlCommand cmd;
            string qry = "select SymtomDescription FROM Symtom";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                symlist.Add(DR.GetString(0));
            }
            return symlist;
        }

        public static void AddGuest()
        {

            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            Guest g = new Guest();

            cusPhone = gPhone;
            g.getPhone = cusPhone;

            cusTable = gTable;
            g.getTable = cusTable;

            cusName = gName;
            g.getName = cusName;

            cusName = gName;
            g.getName = cusName;

            cusTemp = gTemperature;
            g.getTemp = cusTemp;

            SqlCommand cmd;
            SqlCommand cmd1;
            

            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string Gdate = time.ToString(format);
            string GTemdate = time.ToString(format);

            g.getConfirmDate = Gdate;
            g.getConfirTempmDate = GTemdate;

            Country c = new Country();
            Hotel h = new Hotel();
            GuestTitle gut = new GuestTitle();

            string qry = "INSERT INTO Guest (PhoneNum,GuestTable,GuestName,CreationDate,CountryCode,HotelCode,TitleId) VALUES (@cusPhone,@cusTable,@cusName,@Gdate,@conCode,@hotCode,@titID)";
            string qry1 = "INSERT INTO Temperature (PhoneNum,TempValue,TempDate) VALUES (@cusPhone,@cusTemp,@dateTemp)";
            //string qry2 = "INSERT INTO Guest (CountryCode) VALUES (@conCode)";
            c.getCountryCode = Info.AddCountry_;

            h.getHotelCode = View.Login.AddHotel_;

            gut.getTitlelCode = int.Parse(Info.AddTitle_);

            cmd = new SqlCommand(qry, conn);
            cmd1 = new SqlCommand(qry1, conn);
            cmd.Parameters.AddWithValue("@cusPhone", g.getPhone);
            cmd.Parameters.AddWithValue("@cusTable", g.getTable);
            cmd.Parameters.AddWithValue("@cusName", g.getName);
            cmd.Parameters.AddWithValue("@Gdate", g.getConfirmDate);
            cmd.Parameters.AddWithValue("@conCode", c.getCountryCode);
            cmd.Parameters.AddWithValue("@hotCode", h.getHotelCode);
            cmd.Parameters.AddWithValue("@titID", gut.getTitlelCode);
            cmd.ExecuteNonQuery();
            cmd1.Parameters.AddWithValue("@cusPhone", g.getPhone);
            cmd1.Parameters.AddWithValue("@cusTemp", g.getTemp);
            cmd1.Parameters.AddWithValue("@dateTemp", g.getConfirTempmDate);
            cmd1.ExecuteNonQuery();
          

        }

        public static void UpdateGuest()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();



            Guest g = new Guest();

            string upPhn = Main.MainPhone;
            g.getUpTemp = upCus;
            string upTemp = g.getUpTemp;
           // decimal uptemChe = decimal.Parse(upTemp);
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string Udate = time.ToString(format);

            g.getUpDate = Udate;
            SqlCommand cmd;
            SqlCommand cmd1;


            string qry = "UPDATE  Guest SET ModifyDate=@ModifyDate where PhoneNum=@" + upPhn;
            cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@ModifyDate", Udate);
            cmd.Parameters.AddWithValue("@" + upPhn, upPhn);
            cmd.ExecuteNonQuery();

            string qry1 = "INSERT INTO Temperature (PhoneNum,TempValue,TempDate) VALUES (@cusPhone,@cusTemp,@cusDate)";
            cmd1 = new SqlCommand(qry1, conn);
            cmd1.Parameters.AddWithValue("@cusPhone", upPhn);
            cmd1.Parameters.AddWithValue("@cusTemp", g.getUpTemp);
            cmd1.Parameters.AddWithValue("@cusDate", g.getUpDate);
            cmd1.ExecuteNonQuery();







        }

       


    }
    
}
