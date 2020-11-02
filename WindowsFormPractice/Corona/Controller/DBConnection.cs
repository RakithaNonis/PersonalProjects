using Corona.Model;
using Corona.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona.Controller
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

        public static string Gdate;

        private static string temp_;

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
                //symlist.Add(DR.GetInt32(0));
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
            Country c = new Country();
            Hotel h = new Hotel();
            Title gut = new Title();

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
            SqlCommand cmd2;
            SqlCommand cmd3;

            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            Gdate = time.ToString(format);
            string GTemdate = time.ToString(format);

            g.getConfirmDate = Gdate;
            g.getConfirTempmDate = GTemdate;

            string qry = "INSERT INTO Guest (PhoneNum,GuestName,CreationDate,CountryCode,TitleId) VALUES (@cusPhone,@cusName,@Gdate,@conCode,@titID)";
            string qry1 = "INSERT INTO Temperature (TempValue,TempDate,PhoneNum) VALUES (@cusTemp,@dateTemp,@cusPhone)";
            //string qry2 = "INSERT INTO Checkin (ChekinDate,HotelCode,ReservationNum,PhoneNum) VALUES (@Gdate,@hotCode,@cusTable,@cusPhone)";


            c.getCountryCode = Info.AddCountry_;
            gut.getTitlelCode = int.Parse(Info.AddTitle_);
            h.getHotelCode = View.Login.AddHotel_;

            cmd = new SqlCommand(qry, conn);
            cmd1 = new SqlCommand(qry1, conn);
           // cmd2 = new SqlCommand(qry2, conn);


            cmd.Parameters.AddWithValue("@cusPhone", g.getPhone);
            cmd.Parameters.AddWithValue("@cusName", g.getName);
            cmd.Parameters.AddWithValue("@Gdate", g.getConfirmDate);
            cmd.Parameters.AddWithValue("@conCode", c.getCountryCode);
            cmd.Parameters.AddWithValue("@titID", gut.getTitlelCode);
            cmd.ExecuteNonQuery();

            cmd1.Parameters.AddWithValue("@cusTemp", g.getTemp);
            cmd1.Parameters.AddWithValue("@dateTemp", g.getConfirTempmDate);
            cmd1.Parameters.AddWithValue("@cusPhone", g.getPhone);
            cmd1.ExecuteNonQuery();

            //cmd2.Parameters.AddWithValue("@Gdate", g.getConfirmDate);
            //cmd2.Parameters.AddWithValue("@hotCode", h.getHotelCode);
            //cmd2.Parameters.AddWithValue("@cusTable", g.getTable);
            //cmd2.Parameters.AddWithValue("@cusPhone", g.getPhone);
            //cmd2.ExecuteNonQuery();



            //Symtoms s = new Symtoms();
            //// string x = "SELECT @@IDENTITY AS 'Identity'";
            //string x = "SELECT @@IDENTITY";
            
            //string qry3 = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId );"+"Select Scope_Identity()";
            //int id_;
            //cmd3 = new SqlCommand(qry3, conn);


            //s.getSymtomlId = Convert.ToInt32(upCus);
            //cmd3.Parameters.AddWithValue("@symId", s.getSymtomlId);
            //cmd3.ExecuteNonQuery();
            //id_ = (int)cmd3.ExecuteScalar();

        }

        public static void UpdateGuest()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();



            Guest g = new Guest();
            Hotel uh = new Hotel();

            string upPhn = Main.MainPhone;
            g.getUpTemp = Update.UpValTemp_;
            //string upTemp = g.getUpTemp;
            // decimal uptemChe = decimal.Parse(upTemp);
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string Udate = time.ToString(format);

            uh.getHotelCode = Update.UpAddHotel_;

            //g.getUpRes = decimal.Parse(Update.UpRes_);
            g.getUpDate = Udate;
            SqlCommand cmd;
            SqlCommand cmd1;


    

            string qry1 = "INSERT INTO Temperature (PhoneNum,TempValue,TempDate) VALUES (@cusPhone,@cusTemp,@cusDate)";
            cmd1 = new SqlCommand(qry1, conn);
            cmd1.Parameters.AddWithValue("@cusPhone", upPhn);
            cmd1.Parameters.AddWithValue("@cusTemp", g.getUpTemp);
            cmd1.Parameters.AddWithValue("@cusDate", g.getUpDate);
            cmd1.ExecuteNonQuery();

          

        }

        public static void PassCheckin()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            Guest a = new Guest();

            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            Gdate = time.ToString(format);
            a.getConfirmDate = Gdate;
            SqlCommand cmd;

            string qry = "INSERT INTO GuestSymtom(CheckinId) SELECT CheckinId from Checkin   where PhoneNum = @x And ChekinDate =@y";

            //string qry = "INSERT INTO GuestSymtom (CheckinId) SELECT TOP 1 * from Checkin ORDER BY CheckinId DESC LIMIT 1 CheckinId  where PhoneNum = @x";
            cmd = new SqlCommand(qry, conn);

            cmd.Parameters.AddWithValue("@x", Main.MainPhone);
            cmd.Parameters.AddWithValue("@y", a.getConfirmDate);
            cmd.ExecuteNonQuery();



        }

        public static void passSym()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd3;
            Symtoms s = new Symtoms();



            s.getSymtomlId= Convert.ToInt32(upCus);
            string qry3 = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId)";
           
            cmd3 = new SqlCommand(qry3, conn);
            cmd3.Parameters.AddWithValue("@symId",s.getSymtomlId);
          
            cmd3.ExecuteNonQuery();


        }

        public static List<int> Test()
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();
            List<int> getCID = new List<int>();


            SqlCommand cmd;
            string qry = "select CheckinId FROM Checkin";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                getCID.Add(DR.GetInt32(0));

            }

            return getCID;

        }
    }
}
