using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Models.Interfaces
{
    public interface ICar: IDataErrorInfo
    {
        event EventHandler<GameEndEventArgs> GameEnd;
        int? InitialPosition { get; set; }
        int? InitialVelocity { get; set; }
        bool IsGameRunning { get; set; }



        void Play();
        void Stop();
        void RandomValues();

    }
}
