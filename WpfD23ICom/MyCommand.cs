using System.Windows.Input;

namespace WpfD23ICom
{
    internal class MyCommand : ICommand
    {
        private Action<Object?> callBack;

        public MyCommand(Action<Object> callBack)
        {
            this.callBack = callBack;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //not view model
            System.Diagnostics.Debug.WriteLine("Called");
            callBack(parameter);
        }
    }
}