using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modal;

namespace Database
{
    public class VisDAO
    {
        public List<Vis> visList;
        public VisDAO()
        {
            visList = new List<Vis>();
            Vis vis = new Vis(1, "Bittervoorn", "Is erg bitter");
            Vis vis2 = new Vis(2, "Snoekbaars", "Het is een stevige vis met een relatief neutrale smaak.");
            Vis vis3 = new Vis(1, "zeeforellen", "Een fijne structuur en een lekkere, vrij neutrale smaak. Erg neutraal");
            Vis vis4 = new Vis(1, "Makreel", "Vis met veel graten.");
            visList.Add(vis);
            visList.Add(vis2);  
            visList.Add(vis3);  
            visList.Add(vis4);
        }

        public List<Vis> getVis()
        {
            return visList;
        }
    }
}
