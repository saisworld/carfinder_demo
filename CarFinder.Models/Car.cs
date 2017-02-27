using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Timers;
using System.Windows.Threading;
using CarFinder.Agents.Implementations;
using CarFinder.Agents.Interfaces;
using CarFinder.Helpers;
using CarFinder.Models.Implementations;
using CarFinder.Models.Interfaces;


namespace CarFinder.Models
{
    public class Car : NotifyPropertyChangedBase, ICar
    {
        private readonly Random _random = new Random();
        private ITimerForGame _gameTimer;
        private object _lock = new object();

        private int _currentPosition;
        private int _currentTickCount;

        private ICarFinderManager _carFinderManager;
        

        public Car(ICarFinderManager carFinderManager)
        {
            _gameTimer = new DispatchTimerForWPF(TickEvent);
            CarFoundResults = new ObservableCollection<CarFoundResult>();
           _carFinderManager = carFinderManager;
        }

        public Car(int initialPosition, int initialVelocity, ICarFinderManager carFinderManager)
        {
            InitialPosition = initialPosition;
            InitialVelocity = initialVelocity;
            _gameTimer = new SystemTimerForConsole(TickEvent);
            CarFoundResults = new ObservableCollection<CarFoundResult>();
            _carFinderManager = carFinderManager;

        }

        #region properties

        private int? _initialPosition;
        public int? InitialPosition
        {
            get { return _initialPosition; }
            set
            {
                _initialPosition = value;
                if (_initialPosition != null) _currentPosition = (int) _initialPosition;
                NotifyPropertyChanged("InitialPosition");
            }   
        }

        public ObservableCollection<CarFoundResult> CarFoundResults { get; set; }

        private int? _initialVelocity;
        public int? InitialVelocity
        {
            get { return _initialVelocity; }
            set
            {
                _initialVelocity = value;
                NotifyPropertyChanged("InitialVelocity");
            }
        }

        private bool _isGameRunning = false;
        public bool IsGameRunning
        {
            get { return _isGameRunning; }
            set
            {
                _isGameRunning = value;
                NotifyPropertyChanged("IsGameRunning");
            }
        }

        #endregion

        
        public void Play()
        {
            //reset
            if (_gameTimer != null && InitialPosition != null & InitialVelocity != null)
            {
                _gameTimer.Stop();
                IsGameRunning = false;
                CarFoundResults.Clear();
                _currentTickCount = 0;

                //start the game
                _gameTimer.Start();
                IsGameRunning = true;

            }
        }

        public void Stop()
        {
            if (_gameTimer != null)
            {
                _gameTimer.Stop();
                IsGameRunning = false;
            }
        }
        

        public void RandomValues()
        {
            InitialPosition = ThreadLocalRandom.Next(-1000, 1000);
            InitialVelocity = ThreadLocalRandom.Next(-1000, 1000);
        }


        #region Private methods

        

       

        private void TickEvent(object sender, EventArgs e)
        {
//            Console.WriteLine(e.SignalTime);
            lock (_lock)
            {
                _currentTickCount++;

                //move car forward
                MoveCar();

                //Call find car agents
                var results = _carFinderManager.CallAgents(_currentTickCount);

                results.ForEach(x =>
                {
                    if(x.IsCarFound) CarFoundResults.Add(x);
                });

                // 1 millisecond = 10,000 ticks so 5000000 ticks = 500 milliseconds
                
                if (_currentTickCount >= 500 || CarFoundResults.Count == 2)
                {
                    //game ended
                    _gameTimer.Stop();
                    IsGameRunning = false;
                    foreach (var carFoundResult in results)
                    {
                        if (!carFoundResult.IsCarFound)
                        {
                            carFoundResult.Position = null;
                            carFoundResult.CarFoundTime = null;
                        }
                        CarFoundResults.Add(carFoundResult);
                    }

                    //raise the game end event
                    OnGameEnd(new GameEndEventArgs()
                    {
                        CarFoundResults = CarFoundResults
                    });
                }
            }
        }

        
        private void MoveCar()
        {
            _currentPosition = _initialPosition.Value + _currentTickCount*InitialVelocity.Value;
        }


        #endregion


        #region Events
        public event EventHandler<GameEndEventArgs> GameEnd;

        protected virtual void OnGameEnd(GameEndEventArgs e)
        {
            var handler = GameEnd;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion




        #region IDataErrorInfo 

        public string this[string columnName]
        {
            get
            {
                var result = string.Empty;
                switch (columnName)
                {

                    case "InitialPosition":
                        if (InitialPosition == null)
                            result = "InitialPosition is required!";
                        else if (InitialPosition < -1000 || InitialPosition > 1000)
                            result = "Initial position must be between -1000 and 1000";
                        break;
                        
                    case "InitialVelocity":
                        if (InitialVelocity == null)
                            result = "Velocity is required!";
                        else if (InitialVelocity < -1000 || InitialVelocity > 1000)
                            result = "Velocity must be between -1000 and 1000";
                        break;
                        /*
                        case "Amount":
                            if ((Amount < 1) || (Amount > 100)) result = "Amount must be between 1 and 100";
                            break;*/

                };

                return result;
            }
        }

        public string Error { get; }
#endregion
    }
}
