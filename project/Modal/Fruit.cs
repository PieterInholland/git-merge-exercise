using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modal
{
    public class Fruit
    {
        public Fruit(int id,string name, string description)
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
