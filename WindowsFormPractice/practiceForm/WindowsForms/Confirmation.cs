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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtConSms_Click(object sender, EventArgs e)
        {

        }

        private void TxtConFname_Click(object sender, EventArgs e)
        {

        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            TxtConFname.Text = Form1.Fname;
            TxtConLname.Text = Form1.Lname;
            TxtConEmail.Text = Form1.Email;

            if (Form1.sms)
            {
                TxtConSms.Text = "🗸";
               
            }
            if (Form1.reports)
            {
                TxtConRepo.Text = "🗸";

            }
            if (Form1.transactions)
            {
                TxtConTrans.Text = "🗸";

            }
        }

        private void BtnOkay_Click(object sender, EventArgs e)
        {
            Application.Exit();
   
        }

        private void LblConFname_Click(object sender, EventArgs e)
        {

        }
    }
}
