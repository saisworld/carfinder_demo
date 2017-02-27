using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarFinder.Core.Annotations;
using Sullinger.ValidatableBase.Models.ValidationRules;
using Sullinger.ValidatableBase.Models;


namespace CarFinder.Core.Models
{
    public class Car : NotifyPropertyChangedBase, IDataErrorInfo
    {
        public int InitialPosition { get; set; }
        
        public int Velocity { get; set; }





        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

     
    }
}
