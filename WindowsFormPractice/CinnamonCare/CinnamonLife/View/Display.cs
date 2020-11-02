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
   
    public partial class Display : Form
    {
        public string registrationNum_;
        public string brand_;
        public string owner_;
        public string price_;
        public string vehicleFindId_;
        public Display()
        {
            InitializeComponent();
        }
        public Display(string _findveh,string _reg,string _brd,string _owr,string _prc)
        {
            InitializeComponent();
            vehicleFindId_ = _findveh;
            registrationNum_ = _reg;
            brand_ = _brd;
            owner_ = _owr;
            price_ = _prc;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            VTtxtC.Text = vehicleFindId_;
            RNtxtC.Text = registrationNum_;
            BrtxtC.Text = brand_;
            ONtxtC.Text = owner_;
            PrtxtC.Text = price_;

        }
    }
}
