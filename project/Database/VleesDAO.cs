using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modal;

namespace Database
{
    public class VleesDAO
    {
        // fake database
        Vlees vlees1 = new Vlees(1, "Grilworst", "Een verse grilworst van de slager.");
        Vlees vlees2 = new Vlees(2, "Ham", "Ham, lekker.");
        Vlees vlees3 = new Vlees(3, "Kippenbout", "Vers geslacht.");
        Vlees vlees4 = new Vlees(4, "Dubious Food", "It's too gross to even look at. A bizarre smell issues forth from this heap. Eating it won't hurt you, though...probably."); // ;)
        Vlees vlees5 = new Vlees(5, "Gehaktbal", "Vers gemaakt door de lokale slager.");
        Vlees vlees6 = new Vlees(6, "Auf Wieder Schnitzel", "Auf wiedersehen!");
        Vlees vlees7 = new Vlees(7, "Spaanse Worstjes", "Je krijgt het hier spaans benauwd van.");

        List<Vlees> vleesLijst = new List<Vlees>();

        public VleesDAO()
        {
            vleesLijst.Add(vlees1);
            vleesLijst.Add(vlees2);
            vleesLijst.Add(vlees3);
            vleesLijst.Add(vlees4);
            vleesLijst.Add(vlees5);
            vleesLijst.Add(vlees6);
            vleesLijst.Add(vlees7);
        }

        public List<Vlees> GetAll()
        {
            return vleesLijst;
        }
    }
}
