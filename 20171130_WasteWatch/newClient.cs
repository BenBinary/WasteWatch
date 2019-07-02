using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _20171130_WasteWatch
{
    public partial class newClient : Form


    {

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string globalConnectionString;
        int i;
        public bool nc_check;

        public newClient()
        {
            InitializeComponent();
        }

        public bool NewClient(string con)
        {
            globalConnectionString = con;
            return nc_check;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string ncName = txtClientName.Text;
            string ncContact = txtClientContact.Text;

            int ZIP = Convert.ToInt32(txtZIP.Text);
            int HouseNo = Convert.ToInt32(txtHousNo.Text);

            string City = txtCity.Text;
            string Street = txtStreet.Text;

            con.ConnectionString = globalConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "insert into Kunden (Kunde, Ansprechpartner, Strasse, Hausnummer, PLZ, Ort) values ('" + ncName + "', '" + ncContact + "', '" + Street + "', '" + Convert.ToString(HouseNo) + "', '" + Convert.ToString(ZIP) + "', '" + City + "');";

            try
            {
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
                nc_check = true;
               
            }
            catch (Exception ex)
            {
                i = 0;
      
            }

            //Form1 f1Update = new Form1();
            //f1Update.F1Refresh();
            this.Close();
            

        }


        public void reqClient(string parReqCon, string parReqName)
        {

            clCust reqClCust = new clCust();

            reqClCust.getCust(parReqCon, parReqName);

            txtCity.Text = reqClCust.ort;
            txtClientName.Text = reqClCust.name;
            txtClientContact.Text = reqClCust.contact;
            txtHousNo.Text = Convert.ToString(reqClCust.Hausnummer);
            txtZIP.Text = Convert.ToString(reqClCust.PLZ);
            txtStreet.Text = reqClCust.strasse;




        }
    }
}
