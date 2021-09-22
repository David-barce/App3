using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using App3.ViewModels;

namespace App3.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string nombrePropiedad)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nombrePropiedad));
        }

    }

}
