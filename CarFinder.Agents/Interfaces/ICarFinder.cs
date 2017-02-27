using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Agents.Interfaces
{
    public interface ICarFinder
    {
        string Name { get; set; }
        bool IsCarFound { get; set; }
        int Find(int tickerCount);

    }
}
