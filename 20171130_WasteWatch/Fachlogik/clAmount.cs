using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _20171130_WasteWatch
{
    public class clAmount
    {
        public string custName;
        public int amoAmount; // = new int[];
        public int custID;
        public DateTime amoDate; // = new DateTime[];
        public string amoArt; // = new string[];

        public OleDbConnection con = new OleDbConnection();
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataReader reader;
        public OleDbDataReader reader_2;

        public clAmount()
        {

        }

    }
}
