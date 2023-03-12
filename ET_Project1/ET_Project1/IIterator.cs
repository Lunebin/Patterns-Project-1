using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_Project1
{
    public interface IIterator
    {
        // functions to implement
        HeavyObject First();
        void Next();
        int Current();
        void Prev();
        bool IsDone();
        HeavyObject CurrentItem();
        HeavyObject NextItem();
        HeavyObject PreviousItem();
    }
}
