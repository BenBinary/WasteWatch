using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171130_WasteWatch.Fachlogik
{
    class Bundesland
    {

        public int id { get; set; }
        public String kurzbezeichnung { get; set; }
        public String bezeichnung { get; set; }

        public Bundesland()
        {

        }

        public Bundesland(int pID, String pKurzbezeichnung) {
            this.kurzbezeichnung = pKurzbezeichnung;
            this.id = pID;
        }

    }
}
