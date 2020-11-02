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

namespace CoronaNew.View
{
    public partial class Main : Form
    {
        public static string MainPhone;


        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //SqlConnection conn;
            //string connStr = Properties.Settings.Default.ConStr;
            //conn = new SqlConnection(connStr);
            //conn.Open();

            //SqlCommand cmd;
            //string sql = "SELECT COUNT(*) FROM Guest WHERE PhoneNum = @MainPhone";

            //cmd = new SqlCommand(sql, conn);
            //cmd.Parameters.AddWithValue("@MainPhone", MainPhone);
            //int UserExist = (int)cmd.ExecuteScalar();

            //if (UserExist > 0)
            //{
              

            //    MessageBox.Show("user is exist ...WELCOME ");
            //    Update up = new Update();
            //    up.Show();
            //    this.Hide();

            //}
            //else
            //{

                Login lg = new Login(phnLblTxt.Text);
                lg.Show();
                this.Hide();

           // }



        }
    }
}
