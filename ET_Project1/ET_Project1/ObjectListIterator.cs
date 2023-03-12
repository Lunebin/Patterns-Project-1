using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ET_Project1
{
    public class ObjectListIterator : HeavyObjectList, IIterator
    {
        private List<HeavyObject> heavyObjects;
        private int index = 0;

        // pass heavyobject list from HeavyObjectList
        public ObjectListIterator(List<HeavyObject> h)
        {
            heavyObjects = h;
        }

        // implement interface functions
        public HeavyObject CurrentItem()
        {
            return heavyObjects[index];
        }
        public HeavyObject NextItem()
        {
            return heavyObjects[index + 1];
        }
        public HeavyObject PreviousItem()
        {
            return heavyObjects[index - 1];
        }
        public HeavyObject First()
        {
            return heavyObjects[0];
        }
        public bool IsDone()
        {
            return index >= heavyObjects.Count() - 1;
        }
        public void Next()
        {
            index++;
        }
        public int Current()
        {
            return index;
        }
        public void Prev()
        {
            index--;
        }
    }
}
