using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace PetProject
{
    public class Dog : INotifyPropertyChanged
    {
        private string _name;
        private string _number;
        public event PropertyChangedEventHandler PropertyChanged;


        public Dog(string name, int number)
        {
            Name = name;
            Number = number.ToString("D4");
        }

        public String Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                    NotifyPropertyChanged(nameof(Name));
                }
            }
        }

        public String Number
        {
            get { return _number; }
            set
            {
                if (value != _number)
                {
                    _number = value;
                    NotifyPropertyChanged(nameof(Number));
                }
            }
        }

        protected void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
