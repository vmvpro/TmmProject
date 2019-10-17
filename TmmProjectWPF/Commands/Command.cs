using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TmmProjectWPF.Commands
{
    public class Command : ICommand
    {
        Action _command;

        public Command(Action _command)
        {
            this._command = _command;
        }

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();

            _command.Invoke();
        }
    }
}
