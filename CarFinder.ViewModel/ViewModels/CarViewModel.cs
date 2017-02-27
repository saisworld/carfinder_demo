using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CarFinder.Models;
using CarFinder.Models.Implementations;
using CarFinder.Models.Interfaces;

namespace CarFinder.ViewModel.ViewModels
{
    public class CarViewModel : ViewModelBase
    {
        public ICar CarModel { get; set; }
        public ICommand PlayCommand { get; set; }
        public ICommand RandomValues { get; set; }
        public ICommand StopCommand { get; set; }

        public CarViewModel()
        {

            CarModel = new Car(new CarFinderManager());
            PlayCommand = new DelegateCommand(Play);
            RandomValues = new DelegateCommand(CarModel.RandomValues);
            StopCommand = new DelegateCommand(CarModel.Stop);

        }

        private void Play()
        {
            if (CarModel.IsGameRunning)
            {
                //TODO: show user popup that game is still running
            }

            

            CarModel.Play();
        }
    }

   }
