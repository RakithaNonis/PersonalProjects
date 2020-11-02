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
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();
            MainPhone = phnLblTxt.Text;
            Regex re = new Regex("[A - z]");
           
            if (MainPhone.ToString().Length>10)
            {
                MessageBox.Show("Phone number is too long");
            }
            else if (re.IsMatch(MainPhone.ToString()))
            {
                MessageBox.Show("Phone number is invalid");
            }

            else if (MainPhone.ToString().Length < 10) 
            
            {
                MessageBox.Show("Phone number is too short");
            }
            else if(MainPhone.ToString().Length ==10)
            {
                SqlCommand cmd;
                string sql = "SELECT COUNT(*) FROM Guest WHERE PhoneNum = @MainPhone";

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MainPhone", MainPhone);
                int UserExist = (int)cmd.ExecuteScalar();

                if (UserExist > 0)
                {


                    MessageBox.Show("user is exist ...WELCOME ");
                    Update up = new Update();
                    up.Show();
                    this.Hide();

                }
                else
                {

                    Login lg = new Login(phnLblTxt.Text);
                    lg.Show();
                    this.Hide(); 
                }
            
            

            }
        }
    }
}
