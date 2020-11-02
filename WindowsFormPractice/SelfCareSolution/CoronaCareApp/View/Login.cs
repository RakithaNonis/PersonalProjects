using CoronaCareApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaCareApp.View
{
    public partial class Login : Form
    {
        public static string GPhoneNumber;
        public static string GHotName;

        Display d = new Display();

        public Login()
        {
            InitializeComponent();
        }

        private void Gphn_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            SqlCommand cmd;
            string qry = "select Name FROM Hotels";
            cmd = new SqlCommand(qry, conn);
            SqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {              
                GhtlDrop.Items.Add(DR[0]);
            }

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            GPhoneNumber = GphnTxt.Text;
            GHotName = GhtlDrop.Text;
           
            Controller.DBConnection.AddCustomer();
            d.Show();
        }

        private void GhtlDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }
    }
}
