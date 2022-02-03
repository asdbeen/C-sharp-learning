using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace NotifyChangeEvent.Model
{
    class Employee : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get 
            { 
                return _name;
            }

            set
            {
                _name = value;
                OnPropertyChanged("FullName");
            }
        }

        private string _fullName;

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public string FullName
        {
            get
            {
                return "Mr" + _name;
            }

            set
            {
                _fullName = value;
            }
        }
    }
}
