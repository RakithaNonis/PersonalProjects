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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm li = new LoginForm();
            //li.Show();

            this.Hide();
            Form1 n = new Form1();
            n.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LBLhello.Text="Hello World !";
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            LBLhello.Text = "Hey Rakitha..!";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            LBLhello.Text = "Text has been cancelled";  
        }
    }
}
