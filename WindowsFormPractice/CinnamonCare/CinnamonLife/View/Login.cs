using CinnamonLife.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonLife.View
{
    public partial class Login : Form
    {
      

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void RejBtn_Click(object sender, EventArgs e)
        {

            Details detpg = new Details(RegTxt.Text);
           


            detpg.Show();
            this.Hide();
        }

        private void RegTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegLbl_Click(object sender, EventArgs e)
        {
          
        }
    }
}
