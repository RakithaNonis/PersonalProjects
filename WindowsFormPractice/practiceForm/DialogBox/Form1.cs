using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1: to purchase , press = YES \n 2: for trial version , press = 2 \n" +
                " 3: cancel order.","Purchase Software",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);




        }
    }
}
