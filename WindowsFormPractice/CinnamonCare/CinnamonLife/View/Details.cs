using CinnamonLife.Controller;
using CinnamonLife.Model;
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
    public partial class Details : Form
    {
        private string registrationNum;
        public string findvehid_;


        public Details()
        {
            InitializeComponent();
        }
        public Details(string reg_)
        {
            InitializeComponent();
            registrationNum = reg_;

        }
        public string RegistrationNum {
            get 
            {
                return this.registrationNum;
            }
            set 
            {
                this.registrationNum = value;
            } }

        private void Details_Load(object sender, EventArgs e)
        {
          
            DBConnection objDB = new DBConnection(VehDrop);
            objDB.selectType();
        }

        private void DBtn_Click(object sender, EventArgs e)
        {
            VehDrop.ValueMember = "GetvehicleId";
            VehicleType vehicleTypeid = (VehicleType)VehDrop.SelectedItem;
            findvehid_ = vehicleTypeid.GetvehicleId.ToString();

          
            Display D = new Display(findvehid_, RegistrationNum, BrdTxt.Text,OwTxt.Text,PrTxt.Text);
           
            D.Show();
            DBConnection methDB = new DBConnection();

            AddVehicle vehicle = new AddVehicle();
            vehicle.AddResNumber = int.Parse(RegistrationNum);
            vehicle.AddBrandName = BrdTxt.Text;
            vehicle.AddOwnerName = OwTxt.Text;
            vehicle.AddPrice = decimal.Parse(PrTxt.Text);
            vehicle.AddVehicleId = int.Parse(findvehid_);

            methDB.AddingVehicle(vehicle); 

            this.Hide();
        }
    }
}
 
