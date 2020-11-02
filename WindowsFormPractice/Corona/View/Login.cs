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
    public partial class Login : Form
    {
        public static string drop;
        public static string GPhone;
        public static string AddHotel_;
        public static string Addres_;
        public Login()
        {
            InitializeComponent();
        }
        public Login(string MainPhn_)
        {
            InitializeComponent();
            GPhone = MainPhn_;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //List<string> hotel = DBConnection.Login();

            //foreach (var item in hotel)
            //{
            //    htlLblDrop.Items.Add(item);
            //}



            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            List<Hotel> passHotel = new List<Hotel>();

            SqlCommand cmd;
            string qry = "select HotelCode,HotelName FROM Hotel";
            cmd = new SqlCommand(qry, conn);

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = passHotel;
            htlLblDrop.DataSource = bindingSource2.DataSource;

            SqlDataReader DR = cmd.ExecuteReader();


            while (DR.Read())
            {
                Hotel h = new Hotel(DR.GetString(0), DR.GetString(1));
                h.getHotelCode = DR.GetString(0);
                h.getHotelName = DR.GetString(1);


                passHotel.Add(h);

            }

            htlLblDrop.DisplayMember = "getHotelName";




        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            Regex re = new Regex("[A - Z]");

            if (tblLblTxt.Text.Length == 0 || tblLblTxt.Text.Contains(" ")|| re.IsMatch(tblLblTxt.Text))
            {
                MessageBox.Show("Invalid table number given");
            }
            else if (htlLblDrop.SelectedIndex == -1)
            {
                MessageBox.Show("NOT selected the hotel");
            }
            else 
            {
                htlLblDrop.ValueMember = "getHotelCode";

                Hotel hotel = (Hotel)htlLblDrop.SelectedItem;
                AddHotel_ = hotel.getHotelCode;
                Addres_ = tblLblTxt.Text;
                Info inf = new Info(GPhone, tblLblTxt.Text, htlLblDrop.Text);
                inf.Show();
                this.Hide();
            }


            
        }
    }
}
