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
    public partial class Form1 : Form
    {
        public static string Fname;
        public static string Lname;
        public static string Email;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();

        public Form1()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SMScheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SMScheck.Checked)
            {
                sms = true;
                SMSlbl.Text = "SMS message will be sent";
            }
            else
            {
                sms = false;
                SMSlbl.Text = ".....";
            }
        }

        private void Reportcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Reportcheck.Checked)
            {
                reports = true;
                ReportLbl.Text = "REPORTS message will be sent";
            }
            else
            {
                reports = false;
                ReportLbl.Text = ".....";
            }
        }

        private void Transcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Transcheck.Checked)
            {
                transactions = true;
                transLbl.Text = "TRANSACTION message will be sent";
            }
            else
            {
                transactions = false;
                transLbl.Text = ".....";
            }
        }

        private void SignupBtn_Click(object sender, EventArgs e)
        {
            Fname = FNameTxt.Text;
            Lname = LNameTxt.Text;
            Email = EmailTxt.Text;

            c.Show();
        }

        private void SMSlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
