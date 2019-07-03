using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _20171130_WasteWatch
{
    class clCust 
    {
       public int Hausnummer;
       public string name;
       public string ort;
        public int kundennummer;
       public string strasse;
       public int PLZ;
        public string contact;

        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;

        public clCust getCust(string parCON, string parItem)
        {
            con.ConnectionString = parCON;
            cmd.Connection = con;
            cmd.CommandText = "select * from Kunden where Kunde like '" + parItem + "';";
            con.Open();
            reader = cmd.ExecuteReader();

            reader.Read();
            this.kundennummer = reader.GetInt32(0);
            this.name = reader.GetString(1);
            this.ort = reader.GetString(6);
            this.PLZ = reader.GetInt32(5);
            this.Hausnummer = reader.GetInt32(4);
            this.strasse = reader.GetString(3);
            this.contact = reader.GetString(2);
            
            con.Close();

            return this;



        }



    }
}
