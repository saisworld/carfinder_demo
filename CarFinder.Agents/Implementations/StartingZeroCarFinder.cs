using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Agents.Interfaces;
using CarFinder.Helpers;

namespace CarFinder.Agents.Implementations
{
    /// <summary>
    /// This agent keeps track of previous position and increments by one 
    /// </summary>
    public class StartingZeroCarFinder : ICarFinder
    {
        public string Name { get; set; }
        public bool IsCarFound { get; set; }
        private int _previousPosition;
        private int _previousVelocity;

        public StartingZeroCarFinder()
        {
            Name = "Starting at Zero Car Finder Agent";
        }
        public int Find(int tickerCount)
        {

            _previousPosition++;
            _previousVelocity++;

            return _previousPosition + tickerCount * _previousVelocity;

        }
    }
}
