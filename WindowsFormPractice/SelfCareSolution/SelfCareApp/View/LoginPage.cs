using SelfCareApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfCareApp
{
    public partial class Log : Form
    {
        public static string GPhoneNumber;

        Display d = new Display();

        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            GPhoneNumber = GphnTxt.Text;
            Controller.DBConnection.AddCustomer();

            d.Show();
        }
    }
}
