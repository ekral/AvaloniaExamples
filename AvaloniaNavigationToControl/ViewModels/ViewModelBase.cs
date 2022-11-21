using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaNavigationToControl.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public bool SetProperty<T>(ref T field, T value, [CallerMemberName] string? name = null)
        {
            ArgumentNullException.ThrowIfNull(name);
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

            return true;
        }
    }
}
