using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_Project1
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, StackingStrategy> strategies;
        
        public FlyweightFactory()
        {
            strategies = new Dictionary<string, StackingStrategy>();
        }

        // get flyweight, return created on if type already exists
        public StackingStrategy GetFlyweight(string s)
        {
            if (strategies.ContainsKey(s))
            {
                Console.WriteLine( s + " strategy already made");
                return strategies[s];
            }
            var strategy = new StackingStrategy(s);
            strategies.Add(s, strategy);

            return strategy;
        }
    }
}
