using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInventoryManagement
{
    internal class Rice
    {
        public List<TypesOfRice> typeOfRice;
        public List<TypesOfPluse> typeOfPluse;
        public List<TypesOfWheat> typeOfWheat;
    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPluse
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}
