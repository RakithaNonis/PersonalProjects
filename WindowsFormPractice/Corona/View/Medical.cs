using Corona.Controller;
using Corona.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona.View
{
    public partial class Medical : Form
    {
        public static string Name_;
        public static string Temp_;
        public static string Country_;
        public static string Title_;
        private static decimal Ctemp;
        public static string sym_;
        public static string checkedItems;
         public static int range;

        public static string x;
        public Medical()
        {
            InitializeComponent();
        }
        public Medical(string phn, string tbl, string htl, string nam, string tit, string cnt)
        {

            InitializeComponent();
            Main.MainPhone = phn;
            Info.Table_ = tbl;
            Info.Hotel_ = htl;
            Name_ = nam;
            Title_ = tit;
            Country_ = cnt;
        }

        private void Medical_Load(object sender, EventArgs e)
        {
            //List<string> sym = DBConnection.Symtoms();

            //foreach (var item in sym)
            //{
            //    symLblChk.Items.Add(item);


            //}


            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            //List<Dummy> lst = new List<Dummy>();
            //lst.Add(new Dummy("letter A",1));
            //lst.Add(new Dummy("letter b",2));
            //lst.Add(new Dummy("letter C",3));
            //((ListBox)this.symLblChk).DataSource = lst;
            //((ListBox)this.symLblChk).DisplayMember = "Name";
            //((ListBox)this.symLblChk).ValueMember = "Id";


            List<Symtoms> passSym = new List<Symtoms>();

            SqlCommand cmd;
            string qry = "select SymtomId,SymtomDescription FROM Symtom";
            cmd = new SqlCommand(qry, conn);

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = passSym;

            ((ListBox)this.symLblChk).DataSource = bindingSource1.DataSource;
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                Symtoms s = new Symtoms(DR.GetInt32(0), DR.GetString(1));
                s.getSymtomlId = DR.GetInt32(0);
                s.getSymtomlName = DR.GetString(1);

                passSym.Add(s);

            }
            ((ListBox)this.symLblChk).DisplayMember = "getSymtomlName";

            ((ListBox)this.symLblChk).ValueMember = "getSymtomlId";
            // ((ListBox)this.symLblChk).ValueMember = "getIsChek";




        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd;
            
             
            Ctemp = decimal.Parse(tempLblTxt.Text);
            Regex re = new Regex("[A - z]");

            if (string.IsNullOrEmpty(Ctemp.ToString()) || re.IsMatch(Ctemp.ToString()))
            {
                MessageBox.Show("The temperature value is invalid");
            }
            else if (tempLblTxt.Text.Length == 0)
            {
                MessageBox.Show("The temperature value is NOT given");
            }
            else if (Ctemp > 38)
            {
                MessageBox.Show("can not enter to the hotel Due to high temperature value range.. ");
                   this.Close();
            }
            else if (Ctemp < 29)
            {
                MessageBox.Show("can not enter to the hotel Due to low temperature value range.. ");
                this.Close();
            }
            else
            { //if (Ctemp > 38)
              //{
              //    MessageBox.Show("can not enter to the hotel Due to high temperature value range.. ");
              //    this.Close();
              //}
              //else if (Ctemp < 29)
              //{
              //    MessageBox.Show("can not enter to the hotel Due to low temperature value range.. ");
              //    this.Close();
              //}

                //else
                //{




                //    //for (int i = 0; i < symLblChk.Items.Count; i++)
                //    //{

                //    //    if (symLblChk.GetItemCheckState(i) == CheckState.Checked)
                //    //    {
                //    //        string qry = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId)";
                //    //        //string qry = "INSERT INTO GuestSymtom (SymtomId,CheckinId)  VALUES (@symId) SELECT  CheckinId from Checkin   where PhoneNum = @x";
                //    //        cmd = new SqlCommand(qry, conn);
                //    //        cmd.Parameters.AddWithValue("@symId", (i + 1).ToString());
                //    //        //cmd.Parameters.AddWithValue("@x", Main.MainPhone);
                //    //        range = (i + 1);
                //    //        cmd.ExecuteNonQuery();


                //    //        //string qry1 = "INSERT INTO GuestSymtom (CheckinId) SELECT  CheckinId from Checkin   where PhoneNum = @x";
                //    //        //cmd3 = new SqlCommand(qry1, conn);
                //    //        //cmd3.Parameters.AddWithValue("@x", Main.MainPhone);

                //    //        //cmd3.ExecuteNonQuery();
                //    //        // DBConnection.PassCheckin();
                //    //    }

                //}

                DBConnection db = new DBConnection(Main.MainPhone, Info.Table_, Info.Hotel_, Title_, Name_, Country_, Ctemp);
                foreach (Symtoms item in symLblChk.CheckedItems)
                {
                    checkedItems += item.getSymtomlName + "\n ";
                }

                Display dis = new Display(Main.MainPhone, Info.Table_, Name_, Info.Hotel_, Title_, Country_, Ctemp);


                DBConnection.AddGuest();

                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
               string Gdate = time.ToString(format);
                string GTemdate = time.ToString(format);
                SqlCommand cmd2;
                Guest g = new Guest();
                g.getConfirmDate = Gdate;
                string qry2 = "INSERT INTO Checkin (ChekinDate,HotelCode,ReservationNum,PhoneNum) VALUES   (@Gdate,@hotCode,@cusTable,@cusPhone);"+ "SELECT @@IDENTITY AS 'Identity'";
               // string qry2 = "INSERT INTO Checkin (ChekinDate,HotelCode,ReservationNum,PhoneNum) VALUES (@Gdate,@hotCode,@cusTable,@cusPhone)";

                cmd2 = new SqlCommand(qry2, conn);
                cmd2.Parameters.AddWithValue("@Gdate", g.getConfirmDate);
                cmd2.Parameters.AddWithValue("@hotCode", Login.AddHotel_);
                cmd2.Parameters.AddWithValue("@cusTable", Login.Addres_);
                cmd2.Parameters.AddWithValue("@cusPhone",Main.MainPhone);
                cmd2.ExecuteNonQuery();

                // var x = " @@IDENTITY";
                //int y = int.Parse(x);

                // string x;
                List<int> CID = DBConnection.Test();

                for (int i = 0; i < CID.Count; i++)
                {
                    if (i==CID.Count-1)
                    {
                        x = CID[i].ToString();
                       // MessageBox.Show(x);
                    }
                }


                








                // DBConnection.PassCheckin();
                foreach (Symtoms item in symLblChk.CheckedItems)
                {
                    Checkin c = new Checkin();
                    // c.getCid = Convert.ToInt32(x);
                   c.getCid = x;
                    SqlCommand cmd3;
                    // string q = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId)";
                    string q = "INSERT INTO GuestSymtom  VALUES (@symId,@x)";
                    cmd3 = new SqlCommand(q, conn);
                    cmd3.Parameters.AddWithValue("@symId", item.getSymtomlId.ToString());
                   cmd3.Parameters.AddWithValue("@x",c.getCid);
                  
                    cmd3.ExecuteNonQuery();







                    //  Checkin c = new Checkin();
                    //  SqlCommand cmd3;
                    //   string q = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId );" + "SELECT @@IDENTITY AS 'Identity'";
                    ////  string q = "INSERT INTO GuestSymtom (SymtomId,CheckinId) VALUES (@symId ,@x )";
                    //  cmd3 = new SqlCommand(q, conn);
                    //  cmd3.Parameters.AddWithValue("@symId",item.getSymtomlId.ToString());

                    //  // cmd3.Parameters.AddWithValue("@x", c.getCid);
                    //  // cmd3.ExecuteNonQuery();
                    //  cmd3.ExecuteScalar();
                    //  //DBConnection stn = new DBConnection(item.getSymtomlId.ToString());
                    //  //DBConnection.passSym();
                }
                dis.Show();
                this.Hide();
                // DBConnection.PassCheckin();
            }
        }






    }
}

