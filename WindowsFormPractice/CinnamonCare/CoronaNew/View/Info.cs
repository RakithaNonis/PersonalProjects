using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaNew.View
{
    public partial class Info : Form
    {
        public static string Phone_;
        public static string Table_;
        public static string Hotel_;
        public static string AddCountry_;
        public static string AddTitle_;

        public Info()
        {
            InitializeComponent();
        }
        public Info(string phn, string tbl, string htl)
        {
            InitializeComponent();
            Phone_ = phn;
            Table_ = tbl;
            Hotel_ = htl;


        }
        private void Info_Load(object sender, EventArgs e)
        {
            //SqlConnection conn;
            //string connStr = Properties.Settings.Default.ConStr;
            //conn = new SqlConnection(connStr);
            //conn.Open();

            //List<Country> passCountry = new List<Country>();

            //SqlCommand cmd;
            //string qry = "select CountryCode,CountryName FROM Country";
            //cmd = new SqlCommand(qry, conn);

            //var bindingSource1 = new BindingSource();
            //bindingSource1.DataSource = passCountry;
            //ctryLblDrop.DataSource = bindingSource1.DataSource;

            //SqlDataReader DR = cmd.ExecuteReader();


            //while (DR.Read())
            //{
            //    Country c = new Country(DR.GetString(0), DR.GetString(1));
            //    c.getCountryCode = DR.GetString(0);
            //    c.getCountryName = DR.GetString(1);


            //    passCountry.Add(c);

            //}

            //ctryLblDrop.DisplayMember = "getCountryName";




            //List<GuestTitle> passTitle = new List<GuestTitle>();

            //SqlCommand cm1;
            //string qry1 = "select TitleDescription, TitleId FROM GuestTitle";
            //cm1 = new SqlCommand(qry1, conn);

            //var bindingSource3 = new BindingSource();
            //bindingSource3.DataSource = passTitle;
            //ttlLblDrop.DataSource = bindingSource3.DataSource;

            //DR.Close();

            //SqlDataReader DR1 = cm1.ExecuteReader();


            //while (DR1.Read())
            //{
            //    GuestTitle gt = new GuestTitle(DR1.GetString(0), DR1.GetInt32(1));
            //    gt.getTitlelName = DR1.GetString(0);
            //    gt.getTitlelCode = DR1.GetInt32(1);



            //    passTitle.Add(gt);

            //}
            //ttlLblDrop.DisplayMember = "getTitlelName";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Regex re = new Regex("[0 - 9]");

            //if (string.IsNullOrWhiteSpace(nameLblTxt.Text) || re.IsMatch(nameLblTxt.Text))
            //{
            //    MessageBox.Show("Invalid User Name given");
            //}
            //else if (ttlLblDrop.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Guest Title is NOT given");
            //}
            //else if (ctryLblDrop.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Guest country is NOT given");
            //}
            //else
            //{
                //ctryLblDrop.ValueMember = "getCountryCode";

                //Country country = (Country)ctryLblDrop.SelectedItem;
                //AddCountry_ = country.getCountryCode;

                //ttlLblDrop.ValueMember = "getTitlelCode";
                //GuestTitle hotel = (GuestTitle)ttlLblDrop.SelectedItem;
                //AddTitle_ = hotel.getTitlelCode.ToString();


                Medical med = new Medical(Phone_, Table_, Hotel_, nameLblTxt.Text, ttlLblDrop.Text, ctryLblDrop.Text);
                med.Show();
                this.Hide();
            }

        }
    }
}
