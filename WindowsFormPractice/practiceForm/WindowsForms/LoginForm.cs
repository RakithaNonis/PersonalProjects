using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void Login() 
        {
            string id = TxtUserid.Text;
            string pass = txtPassword.Text;

            if (id == "123" && pass == "12345")
            {
                this.Hide();
                Form2 f = new Form2();
                f.Show();


            }
            else
            {
                MessageBox.Show("Incorrect User Id or Password..!");
            }

        }

        private void ResetMyForm() 
        {
            TxtUserid.Text = null;
            txtPassword.Text = null;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResetMyForm();
        }

        private void TxtUserid_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserLbl_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar==(char)Keys.Escape)
            {
                ResetMyForm();
            }
        }
    }
}
