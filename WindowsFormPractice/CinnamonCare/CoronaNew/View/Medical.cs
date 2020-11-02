using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaNew.View
{
    public partial class Medical : Form
    {
        public static string Name_;
        public static string Temp_;
        public static string Country_;
        public static string Title_;
        private static decimal Ctemp;
        public static string sym_;
        public static string checkedItems;
        public static bool isCheck;
        public Medical()
        {
            InitializeComponent();
        }
        public Medical(string phn, string tbl, string htl, string nam, string tit, string cnt)
        {

            InitializeComponent();
            Main.MainPhone = phn;
            Info.Table_ = tbl;
            Info.Hotel_ = htl;
            Name_ = nam;
            Title_ = tit;
            Country_ = cnt;
        }

        private void Medical_Load(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

        }
    }
}
