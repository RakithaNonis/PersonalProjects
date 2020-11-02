using CinnamonCare.Controller;
using CinnamonCare.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonCare.View
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(UptempLblTxt.Text) > 38 || decimal.Parse(UptempLblTxt.Text) < 29)
            {
                MessageBox.Show("you canot enter to the hotel due to high temperature");
                this.Close();   
            }
            else 
            {
                DBConnection Dbl = new DBConnection(UptempLblTxt.Text);
                DBConnection.UpdateGuest();
                MessageBox.Show("Updated the guest details..Thank you");
                this.Close();
            }

           
        }

        private void Update_Load(object sender, EventArgs e)
        {
            
        }
    }
}
