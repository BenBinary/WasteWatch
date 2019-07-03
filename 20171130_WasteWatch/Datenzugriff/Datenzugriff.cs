using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _20171130_WasteWatch.Fachlogik;


namespace _20171130_WasteWatch.Datenzugriff
{
    interface Datenzugriff
    {
        List<Bundesland> Bundeslaender { get; }
        List<Landkreis> Landkreis { get;  }


    }
}
