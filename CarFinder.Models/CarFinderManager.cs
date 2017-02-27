using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Agents.Implementations;
using CarFinder.Agents.Interfaces;

namespace CarFinder.Models
{
    public class CarFinderManager : ICarFinderManager
    {
        private readonly List<ICarFinder> _carFinders;

        public CarFinderManager()
        {
            _carFinders = new List<ICarFinder>()
            {
                new RandomCarFinder(),
                new StartingZeroCarFinder()
            };
        }

        /// <summary>
        /// loops through all the agents and returns the results in a list
        /// </summary>
        /// <param name="currentTickCount"></param>
        /// <returns></returns>
        public List<CarFoundResult> CallAgents(int currentTickCount)
        {
            var carFoundResults = new List<CarFoundResult>();
            foreach (var carFinder in _carFinders)
            {
               var carFoundResult = FindTheCar(carFinder, currentTickCount);
                if(carFoundResult != null) 
                    carFoundResults.Add(carFoundResult);
            }

            return carFoundResults;
        }

        private CarFoundResult FindTheCar(ICarFinder carFinder,int currentTickCount)
        {
            if (carFinder.IsCarFound) return null;

            //call Find method agent
            var calculatedCarPosition = carFinder.Find(currentTickCount);

            var result = new CarFoundResult()
            {
                CarFoundTime = currentTickCount,
                FinderName = carFinder.Name,
                IsCarFound = false,
                Position = calculatedCarPosition
            };

            //chceck if the calculated position is matching with currentposition
            if (calculatedCarPosition == currentTickCount) result.IsCarFound = true;

            return result;

        }
    }
}
