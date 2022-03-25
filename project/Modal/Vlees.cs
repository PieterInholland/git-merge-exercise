using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modal
{
    public class Vlees
    {
        public int id;
        public string name;
        public string description;

        public Vlees(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
