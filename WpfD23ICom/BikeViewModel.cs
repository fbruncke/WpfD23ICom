using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfD23ICom
{
    class BikeViewModel
    {
        //*************** Instances variables *****************
        ObservableCollection<Model.Bike> bikes; //Bike instances are created conventionally

        public BikeViewModel()
        {
            bikes = new ObservableCollection<Model.Bike>();
            bikes.Add(new Model.Bike { Brand = "SCO", NumberOfGears = 7 });
        }

        public ICommand AddBikeCmd => new ICommandBase((Object commandPara) =>
        {
            bikes.Add(new Model.Bike { Brand = "Cube", NumberOfGears = 27 });
            System.Diagnostics.Debug.WriteLine("Add bike");

        });
    }
}
