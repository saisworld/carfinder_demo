using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFinder.Models
{
    public class GameEndEventArgs : EventArgs
    {
        public ObservableCollection<CarFoundResult> CarFoundResults { get; set; }
    }
}
