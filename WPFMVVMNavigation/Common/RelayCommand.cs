using System;
using System.Windows.Input;

namespace WPFMVVMNavigation.Common
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Predicate<object> canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter = null)
        {
            execute(parameter);
        }
    }
}
