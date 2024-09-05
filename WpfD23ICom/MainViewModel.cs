using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfD23ICom
{
    public class MainViewModel
    {
		public MainViewModel()
		{
			//IComClick = new MyCommand(Call);

        }

        private ICommand? iComClick;

		public ICommand? IComClick
        {
			get { 
                if (iComClick == null)
                    iComClick = new MyCommand(Call);
                return iComClick; 
            }
			
		}

        public void Call(Object o)
        {
            System.Diagnostics.Debug.WriteLine("Called on viewmodel");
        }
    }
}
