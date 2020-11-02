using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            LblDate.Text = Calender.Value.ToString();
            LblDateShort.Text = Calender.Value.ToShortDateString();
            LblDateLong.Text = Calender.Value.ToLongDateString();
            LblTimeShort.Text = Calender.Value.ToShortTimeString();
            LblTimeLong.Text = Calender.Value.ToLongTimeString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }
    }
}
