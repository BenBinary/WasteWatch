using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20171130_WasteWatch.Fachlogik
{
    class Landkreis
    {
        public int id { get; set; }
        public String name { get; set; }
        public String kfz_kennzeichen { get; set; }
        public int fk_bundesland { get; set; }

    }
}
