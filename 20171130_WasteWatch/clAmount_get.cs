using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171130_WasteWatch
{
    class clAmount_get : clAmount
    {
        public clAmount_get()
        { }

        

        public List<clAmount> getAmount(string parCusName, string parCon)
        {
            con.ConnectionString = parCon;
            cmd.Connection = con;
            cmd.CommandText = "SELECT id from Kunden where Kunde like '" + parCusName + "';";

            //Öffnen der DB und starten der Abfrage
            con.Open();

            List<clAmount> liClAmount = new List<clAmount>();

            try
            {

                reader = cmd.ExecuteReader();
                reader.Read();
                custID = reader.GetInt32(0);
                con.Close();

                con.Open();

                 cmd.CommandText = "select * from Mengen where Kunde = " + Convert.ToString(custID) + ";";



             reader_2 = cmd.ExecuteReader();

            //int i = 0;
            while (reader_2.Read())
            {
                clAmount ObjCLAmount = new clAmount();

                ObjCLAmount.amoAmount = reader_2.GetInt32(2);
                ObjCLAmount.amoArt = reader_2.GetString(1);
                ObjCLAmount.amoDate = reader_2.GetDateTime(3);

                liClAmount.Add(ObjCLAmount);
           
            }



            con.Close();

            return liClAmount;
            }
            catch (Exception ex)
            {

                return liClAmount;
            }
         

        }
    }
}
