using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using CarFinder.Models.Interfaces;

namespace CarFinder.Models.Implementations
{
    public class SystemTimerForConsole : ITimerForGame
    {
        private Timer _gameTimer;

        public SystemTimerForConsole(ElapsedEventHandler tickHandler)
        {
            _gameTimer = new Timer();
            _gameTimer.Interval = 1;
            _gameTimer.Elapsed += tickHandler;

        }

        public void Stop()
        {
            _gameTimer.Stop();
        }

        public void Start()
        {
            _gameTimer.Start();
        }


      
    }
}
