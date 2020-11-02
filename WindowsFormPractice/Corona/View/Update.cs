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
    public partial class Update : Form
    {
        public static string UpAddHotel_;
        public static string UpRes_;
        public static string UpValTemp_;
        private static string temp_;

        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
        {
              SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

          

            List<Hotel> UppassHotel = new List<Hotel>();

            SqlCommand cmd;
            string qry = "select HotelCode,HotelName FROM Hotel";
            cmd = new SqlCommand(qry, conn);

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = UppassHotel;
            UphtlLblDrop.DataSource = bindingSource2.DataSource;

            SqlDataReader DR = cmd.ExecuteReader();


            while (DR.Read())
            {
                Hotel h = new Hotel(DR.GetString(0), DR.GetString(1));
                h.getHotelCode = DR.GetString(0);
                h.getHotelName = DR.GetString(1);


                UppassHotel.Add(h);

            }

            UphtlLblDrop.DisplayMember = "getHotelName";

           
            List<Symtoms> uppassSym = new List<Symtoms>();



            SqlCommand cmd2;
            string str = "select SymtomId,SymtomDescription FROM Symtom";
            cmd2 = new SqlCommand(str,conn);
            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = uppassSym;

            ((ListBox)this.UpsymLblChk).DataSource = bindingSource3.DataSource;
            DR.Close();
            SqlDataReader DR1 = cmd2.ExecuteReader();
            while (DR1.Read())
            {
                Symtoms s = new Symtoms(DR1.GetInt32(0), DR1.GetString(1));
                s.getSymtomlId = DR1.GetInt32(0);
                s.getSymtomlName = DR1.GetString(1);

                uppassSym.Add(s);

            }
            ((ListBox)this.UpsymLblChk).DisplayMember = "getSymtomlName";

            ((ListBox)this.UpsymLblChk).ValueMember = "getSymtomlId";



        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            Regex re = new Regex("[A - z]");

            if (decimal.Parse(UptempLblTxt.Text) > 38)
            {
                MessageBox.Show("you canot enter to the hotel due to high temperature");
                this.Close();
            }
            else if (decimal.Parse(UptempLblTxt.Text) < 29)
            {
                MessageBox.Show("you canot enter to the hotel due to low temperature");
                this.Close();
            }
            else if (UphtlLblDrop.SelectedIndex == -1)
            {
                MessageBox.Show("Guest hotel is NOT given");
            }
            else if (re.IsMatch(UptempLblTxt.Text)) 
            {
                MessageBox.Show("Temperature is not given");
            }
            else
            {
                SqlConnection conn;
                string connStr = Properties.Settings.Default.ConStr;
                conn = new SqlConnection(connStr);
                conn.Open();
                UpValTemp_ = UptempLblTxt.Text;
                DBConnection.UpdateGuest();


                UphtlLblDrop.ValueMember = "getHotelCode";

                Hotel hotel = (Hotel)UphtlLblDrop.SelectedItem;
                UpAddHotel_ = hotel.getHotelCode;

                UpRes_ = UptblLblTxt.Text;
                
                // DBConnection Dbl = new DBConnection(UptempLblTxt.Text);




                SqlCommand cmd1;

                DateTime time = DateTime.Now;
                string format = "yyyy-MM-dd HH:mm:ss";
                string date = time.ToString(format);

                Guest g = new Guest();
                g.getConfirmDate = date;

                string qrry = "INSERT INTO Checkin (ChekinDate,HotelCode,ReservationNum,PhoneNum) VALUES (@UpcusDate,@Upcushot,@upCusRes,@cusPhone)";
                cmd1 = new SqlCommand(qrry, conn);
                cmd1.Parameters.AddWithValue("@UpcusDate", g.getConfirmDate);
                cmd1.Parameters.AddWithValue("@Upcushot", UpAddHotel_);
                cmd1.Parameters.AddWithValue("@upCusRes", UpRes_);
                cmd1.Parameters.AddWithValue("@cusPhone", Main.MainPhone);
                cmd1.ExecuteNonQuery();

                List<int> testCID = DBConnection.Test();

                for (int i = 0; i < testCID.Count; i++)
                {
                    if (i == testCID.Count - 1)
                    {
                        temp_ = testCID[i].ToString();
                        // MessageBox.Show(x);
                    }
                }


                foreach (Symtoms item in UpsymLblChk.CheckedItems)
                {
                    Checkin c1 = new Checkin();
                    c1.getCid = temp_;
                    SqlCommand cmd3;
                    string q = "INSERT INTO GuestSymtom  VALUES (@symId,@x)";
                    cmd3 = new SqlCommand(q, conn);
                    cmd3.Parameters.AddWithValue("@symId", item.getSymtomlId.ToString());
                    cmd3.Parameters.AddWithValue("@x", c1.getCid);

                    cmd3.ExecuteNonQuery();



                }





                //SqlCommand cmd;

                //for (int i = 0; i < (UpsymLblChk.Items.Count); i++)
                //{
                //    if (UpsymLblChk.GetItemCheckState(i) == CheckState.Checked)
                //    {

                //        string qry = "INSERT INTO GuestSymtom (SymtomId) VALUES (@symId)";

                //        cmd = new SqlCommand(qry, conn);
                //        cmd.Parameters.AddWithValue("@symId", (i + 1).ToString());
                //        cmd.ExecuteNonQuery();


                //    }
                //}

                
               
               

               // DBConnection.PassCheckin();
                MessageBox.Show("Updated the guest details..Thank you");
                this.Close();
            }

        }
        private void symLbl_Click(object sender, EventArgs e)
        {

        }

        private void UpsymLblChk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
