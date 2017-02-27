using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Console.Models;
using CarFinder.Models;
using CsvHelper;

namespace CarFinder.Console
{
    public class FileReadWriteManager
    {
        public InputFileModel GetInputParamsFromCSV()
        {
            System.Console.WriteLine("Reading input parameters from csv file: Input.csv");
            try
            {
                using (var reader = File.OpenText("Files/Input.csv"))
                {
                    var inputCSV = new CsvReader(reader);
                    var inputModel = new InputFileModel();
                    while (inputCSV.Read())
                    {
                        inputModel.InitialPosition = inputCSV.GetField<int>(0);
                        inputModel.InitialVelocity = inputCSV.GetField<int>(1);
                    }
                     return inputModel;
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                var errorModel = new InputFileModel()
                {
                    IsError = true
                };

                return errorModel;

            }
        }

        public void WriteOutputToFile(List<CarFoundResult> records )
        {
            System.Console.WriteLine("Writing results to csv file: results.csv");

            try
            {
                using (var writer = File.CreateText("Files/results.csv"))
                {
                    var writeCSV = new CsvWriter(writer);
                    writeCSV.WriteRecords(records);
                    System.Console.WriteLine("Game over!");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }

        }
    }
}
