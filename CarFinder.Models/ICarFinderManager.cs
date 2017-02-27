using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Agents.Interfaces;

namespace CarFinder.Models
{
    public interface ICarFinderManager
    {
        List<CarFoundResult> CallAgents(int currentTickCount);
    }
}
