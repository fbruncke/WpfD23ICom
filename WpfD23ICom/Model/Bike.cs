using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfD23ICom.Model
{
    class Bike : INotifyPropertyChanged
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set
            {
                brand = value;
                Changed();
            }
        }

        private int numberOfGears;

        public int NumberOfGears
        {
            get { return numberOfGears; }
            set
            {
                numberOfGears = value;
                Changed();
            }
        }

        protected void Changed([CallerMemberName] string Property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Property));
        }
        public event PropertyChangedEventHandler PropertyChanged;

    }

}
