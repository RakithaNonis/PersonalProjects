using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corona.View
{
    public partial class Display : Form
    {
        public decimal gutem;
        public Display()
        {
            InitializeComponent();
        }
        public Display(string phn, string tbl, string nam, string htl, string tit, string cnt, decimal tem)
        {

            InitializeComponent();
            GphnConTxt.Text = phn;
            GtblConTxt.Text = tbl;
            GNamTxt.Text = nam;

            gutem = tem;
            GhtlTxt.Text = htl;
            GtitTxt.Text = tit;
            GctryTxt.Text = cnt;
        }

        private void Display_Load(object sender, EventArgs e)
        {
            Main m = new Main();
            tempLblTxt.Text = gutem.ToString();
            Gsymtxt.Text = Medical.checkedItems;
            m.Show();
        }
    }
}
