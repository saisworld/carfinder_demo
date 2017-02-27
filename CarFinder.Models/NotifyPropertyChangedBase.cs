using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmValidation;

namespace CarFinder.Models
{
    public class NotifyPropertyChangedBase : INotifyPropertyChanged, IDisposable
    {


        #region INotifypropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        //can be overridden in child classes
        public virtual void Dispose()
        {
            
        }

        #endregion


    }
   
}
