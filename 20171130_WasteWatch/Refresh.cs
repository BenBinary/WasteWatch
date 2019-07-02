using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _20171130_WasteWatch
{
    class Refresh
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        List<string> Kunden = new List<string>();


       public List<string> ReRefresh()
        {

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\temp\\WasteWatch2003.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select * from Kunden";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Kunden.Add(Convert.ToString(reader["Kunde"]));
                }
                reader.Close();
                con.Close();
                return Kunden; 
            }
            catch(Exception ex)
            {

                Kunden.Add(ex.Message);
                return Kunden;
            }
        }

 


    }
}
