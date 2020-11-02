using CinnamonCare.Controller;
using CinnamonCare.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonCare.View
{
    public partial class Medical : Form
    {
        public static string  Name_;
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
        //public Medical(string DBcon)
        //{
        //    InitializeComponent();
        //    Info.AddCountry_ = DBcon;
        //}
        public Medical(string phn,string tbl, string htl,string nam,string tit,string cnt)
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
             
            List<string> sym = DBConnection.Symtoms();

            //foreach (var item in sym)
            //{
            //    symLblChk.Items.Add(item);


            //}
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();

            //List<GuestSymtoms> passTitle = new List<GuestSymtoms>();
            //SqlCommand cmd;
            //string qry = "select SymtomId,SymtomDescription FROM Symtom";
            //cmd = new SqlCommand(qry, conn);

            //((ListBox)this.symLblChk).DataSource = passTitle;


             
            //SqlDataReader DR = cmd.ExecuteReader();

            //while (DR.Read())
            //{
            //    GuestSymtoms s = new GuestSymtoms(DR.GetInt32(0), DR.GetString(1));
            //    s.getSymtomlId = DR.GetInt32(0);
            //    s.getSymtomlName = DR.GetString(1);


            //    passTitle.Add(s);

            //}
            // ((ListBox)this.symLblChk).DisplayMember = "getSymtomlName";

            //for (int i = 0; i < symLblChk.Items.Count; i++)
            //{
            //    if (symLblChk.GetItemCheckState(i) == CheckState.Checked)
            //    {
            //        isCheck = true;
            //    }
            //    else
            //    {
            //        isCheck = false;
            //    }


            //}

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            string connStr = Properties.Settings.Default.ConStr;
            conn = new SqlConnection(connStr);
            conn.Open();


            Ctemp = decimal.Parse(tempLblTxt.Text);
            if (tempLblTxt.Text.Length!=0)
            {
                if (Ctemp > 38 || Ctemp < 29)
                {
                    MessageBox.Show("can not enter to the hotel Due to Invalid temperature value range.. ");
                    this.Close();
                }
                else
                {
                    DBConnection db = new DBConnection(Main.MainPhone, Info.Table_, Info.Hotel_, Title_, Name_, Country_, Ctemp);

                    Display dis = new Display(Main.MainPhone, Info.Table_, Name_, Info.Hotel_, Title_, Country_, Ctemp);
                    //foreach (object Item in symLblChk.CheckedItems)
                    //{
                    //    checkedItems += Item.ToString() + "\n ";
                    //}

                    //if (isCheck)
                    //{
                    //    ((ListBox)this.symLblChk).ValueMember = "getSymtomlId";
                    //    dis.Show();
                    //    this.Hide();
                    //    DBConnection.AddGuest();
                    //    GuestSymtoms a = (GuestSymtoms)symLblChk.SelectedItem;
                    //    MessageBox.Show(a.getSymtomlId.ToString());
                    //}


                    ((ListBox)this.symLblChk).ValueMember = "SymtomId";
                    //for (int i = 0; i < symLblChk.Items.Count; i++)
                    //{
                    //    GuestSymtoms obj = (GuestSymtoms)symLblChk.Items[i];
                    //    symLblChk.SetItemChecked(i, );
                    //}


                    dis.Show();
                    this.Hide();
                    DBConnection.AddGuest();
                    

                     MessageBox.Show("successfully added the guest..Thank you");
                } 
            
            }
            else
            {
                MessageBox.Show("NOT given temperature");
            }


        }
    }
}
