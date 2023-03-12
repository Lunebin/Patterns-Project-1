using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_Project1
{
    public class StackingStrategy
    {
        private string type = "";
        public StackingStrategy(string t) { type = t; }

        public string EvaluateStack(HeavyObjectList h)
        {
            string results = "";
            float count = 0;
            // create an iterator
            IIterator i = h.createIterator();

            // bottom weight strategy
            if (type == "bottomWeight")
            {
                while (i.Current() != h.getListLength())
                {
                    count += i.CurrentItem().Mass / (float)(i.Current() + 1);
                    i.Next();
                }
                results = count.ToString();
            }

            // pyramid strategy
            else if (type == "pyramid")
            {
                while (i.IsDone() == false)
                {
                    if (i.CurrentItem().Mass < i.NextItem().Mass)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                    i.Next();
                }
                results = count.ToString();
            }

            // topple stategy
            else if (type == "topple")
            {
                while (i.IsDone() == false)
                {
                    if (i.CurrentItem().Mass > i.NextItem().Mass)
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                    i.Next();
                }
                results = count.ToString();
            }

            // if ever passed an invalid type
            else
            {
                results = "Error: Not a valid type.";
            }

            return results;
        }
    }
}
