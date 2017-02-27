using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarFinder.Console.Interface;
using CarFinder.Console.Models;
using CarFinder.Models;

namespace CarFinder.Console
{
    public class CarFinderProcessor : ICarFinderProcessor
    {
        public CarFinderProcessor()
        {
            
        }
        public void Run()
        {
            var fileMgr = new FileReadWriteManager();
            var inputValues = fileMgr.GetInputParamsFromCSV();
            if (inputValues.IsError)
            {
                System.Console.ReadKey();
            }
            else
            {
                Task.Factory.StartNew(() => ProcessCarFinderInBackground(inputValues));
                
            }
        }

        private void ProcessCarFinderInBackground(InputFileModel inputValues)
        {
            var carModel = new Car(inputValues.InitialPosition, inputValues.InitialVelocity, new CarFinderManager());
            carModel.GameEnd += CarModel_GameEnd;
            carModel.Play();
        }

      
        private void CarModel_GameEnd(object sender, GameEndEventArgs e)
        {
            
            var fileMgr = new FileReadWriteManager();
            fileMgr.WriteOutputToFile(e.CarFoundResults.ToList());
            Environment.Exit(0);

        }
    }


}
