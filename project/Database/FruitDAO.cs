using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modal;

namespace Database
{
    public class FruitDAO
    {
        public List<Fruit> FruitList;
        public FruitDAO()
        {
            FruitList = new List<Fruit>();
            Fruit fruit = new Fruit(1, "Aardbei", "De aardbei of tuinaardbei[1][2] (Fragaria × ananassa) is een veelgeteelde kruising tussen twee Amerikaanse aardbeisoorten, en vooral bekend om zijn eetbare vruchten.");
            Fruit fruit2 = new Fruit(2, "Abrikoos", "De abrikoos (Prunus armeniaca) is een struik- of boomvormige plant die veel gekweekt wordt om de vruchten. De vrucht is een steenvrucht.");
            Fruit fruit3 = new Fruit(3, "Ananas", "De ananas (Ananas comosus) is een tropische plant, oorspronkelijk afkomstig uit Brazilië, Bolivia en Paraguay. De plantensoort behoort tot de bromeliafamilie (Bromeliaceae).");
            Fruit fruit4 = new Fruit(4, "Appel", "De appel is de vrucht van de plant Malus domestica uit de rozenfamilie (Rosaceae).De appel is er in veel smaken, van friszuur tot zoet.Hij wordt vaak rauw genuttigd.");
            Fruit fruit5 = new Fruit(5, "Avocado", "De avocado (Persea americana) is een boom uit Centraal-Amerika. Hij is bekend om zijn gelijknamige voor consumptie geschikte vrucht die ook wel advocaatpeer of, als hij eetrijp is, soms solange genoemd wordt.");
            FruitList.Add(fruit);
            FruitList.Add(fruit2);
            FruitList.Add(fruit3);
            FruitList.Add(fruit4);
            FruitList.Add(fruit5);
        }
        public List<Fruit> getFruit()
        {
            return FruitList;
        }
    }
}
