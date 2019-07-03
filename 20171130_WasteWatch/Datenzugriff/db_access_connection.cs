using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20171130_WasteWatch.Fachlogik;
using System.Data.OleDb;

namespace _20171130_WasteWatch.Datenzugriff
{
    class db_access_connection : Datenzugriff
    {


        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader reader;
        string globalConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\temp\\WasteWatch2003_urban.mdb";

        public db_access_connection()
        {

            con.ConnectionString = globalConnectionString;
            cmd.Connection = con;

        }

        public List<Bundesland> Bundeslaender
        {
            get
            {
                List<Bundesland> bundeslaender = new List<Bundesland>();
                con.Open();
                cmd.CommandText = "Select * from Bundesland;";
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Bundesland bundesland = new Bundesland();
               
                        bundesland.id = reader.GetInt32(0);
                        bundesland.kurzbezeichnung = reader.GetString(1);
                        bundesland.bezeichnung = reader.GetString(2);
                        
                        
               
                    bundeslaender.Add(bundesland);
                }
                con.Close();
                return bundeslaender;
                
            }
        }


        public List<Landkreis> Landkreis(int bundesland)
        {
            List<Landkreis> landkreise = new List<Landkreis>();

            con.Open();
            cmd.CommandText = "Select * from Landkreis WHERE FK_Bundesland="+bundesland+";";
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Landkreis landkreis = new Landkreis();

                landkreis.id = reader.GetInt32(0);
                landkreis.name = reader.GetString(1);
                landkreis.kfz_kennzeichen = reader.GetString(2);
                landkreis.fk_bundesland = reader.GetInt32(3);

                landkreise.Add(landkreis);
            }
            con.Close();
            return landkreise;
        }
    }
}
