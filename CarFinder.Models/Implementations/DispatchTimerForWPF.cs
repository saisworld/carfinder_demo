using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using CarFinder.Models.Interfaces;

namespace CarFinder.Models.Implementations
{
    public class DispatchTimerForWPF : ITimerForGame
    {
        private DispatcherTimer _gameTimer;

        public DispatchTimerForWPF(EventHandler tickEvent)
        {
            _gameTimer = new DispatcherTimer();
            _gameTimer.Tick += tickEvent;
            _gameTimer.Interval = new TimeSpan(1);
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
