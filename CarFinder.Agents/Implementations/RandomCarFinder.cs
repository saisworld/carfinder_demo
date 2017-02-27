using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Agents.Interfaces;
using CarFinder.Helpers;

namespace CarFinder.Agents.Implementations
{
    public class RandomCarFinder : ICarFinder
    {
        public string Name { get; set; }
        public bool IsCarFound { get; set; }

        public RandomCarFinder()
        {
            Name = "Random Car Finder Agent";
            IsCarFound = false;
        }

        public int Find(int tickerCount)
        {
            var randomInitialPosition = ThreadLocalRandom.Next(-1000, 1000);
            var randomInitialVelocity = ThreadLocalRandom.Next(-1000, 1000);

            return randomInitialPosition + tickerCount * randomInitialVelocity;
        }
    }
}
