using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCare.View
{
    public partial class LoginForm : Form
    {
        public static string GphnNumber;


        DisplayForm df = new DisplayForm();
        public LoginForm()
        {
            InitializeComponent();
        }



        private void GphnTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gphn_Click(object sender, EventArgs e)
        {

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            GphnNumber = GphnTxt.Text;
            df.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
