using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            string input;
            if (Radio1.Checked)
            {
                input = Radio1.Text;
                MessageBox.Show(input);
            }
            if (Radio2.Checked)
            {
                input = Radio2.Text;
                MessageBox.Show(input);
            }
            if (Radio3.Checked)
            {
                input = Radio3.Text;
                MessageBox.Show(input);
            }
        }
    }
}
