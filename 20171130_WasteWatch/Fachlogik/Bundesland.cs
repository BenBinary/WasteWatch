using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171130_WasteWatch.Fachlogik
{
    class Bundesland
    {

        int id;
        String kurzbezeichnung;
        String bezeichnung;

        public Bundesland(int pID, String pKurzbezeichnung) {
            this.kurzbezeichnung = pKurzbezeichnung;
            this.id = pID;
        }

    }
}
