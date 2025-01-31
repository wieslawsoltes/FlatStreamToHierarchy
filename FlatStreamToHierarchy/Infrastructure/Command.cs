using System;
using System.Windows.Input;

namespace FlatStreamToHierarchy.Infrastructure
{
    public class Command : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;


        public Command(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute ?? (() => true);
        }


        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;
        // public event EventHandler CanExecuteChanged
        // {
        //     add => CommandManager.RequerySuggested += value;
        //     remove => CommandManager.RequerySuggested -= value;
        // }

        public void Refresh()
        {
            // CommandManager.InvalidateRequerySuggested();
        }
    }
}
