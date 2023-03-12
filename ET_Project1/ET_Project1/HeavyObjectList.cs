using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_Project1
{
    public class HeavyObjectList
    {
        // private list
        private List<HeavyObject> heavyObjects = new List<HeavyObject>();

        // create iterator function
        public IIterator createIterator()
        {
            return new ObjectListIterator(heavyObjects);
        }

        // add heavy object
        public void Add(HeavyObject heavyObject)
        {
            heavyObjects.Add(heavyObject);
        }

        // get length of list
        public int getListLength()
        {
            return heavyObjects.Count;
        }

        // print out heavy objects
        public void Print()
        {
            string results = "";
            foreach(var item in heavyObjects)
            {
                results += "HeavyObject: (" + item.Width + "x" + item.Length + "x"
                    + item.Height + "),\tdensity = " + item.Density + ",\tmass = " + item.Mass + "\n";
            }
            Console.WriteLine(results);
        }
    }
}
