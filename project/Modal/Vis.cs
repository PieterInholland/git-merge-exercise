using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Modal
{
    public class Vis
    {
        public Vis(int id, string name, string description)
        {
            this.id = id;
            this.name = name;   
            this.description = description; 
        }
        public int id;
        public string name;
        public string description;
    }
}
