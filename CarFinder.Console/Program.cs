using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Console.Interface;
using CarFinder.Console.Models;
using CarFinder.Models;
using CsvHelper;

namespace CarFinder.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "Car Finder Game";
            
            ICarFinderProcessor carFinder = new CarFinderProcessor();
            carFinder.Run();
            new System.Threading.AutoResetEvent(false).WaitOne();
            
        }

    }
}
