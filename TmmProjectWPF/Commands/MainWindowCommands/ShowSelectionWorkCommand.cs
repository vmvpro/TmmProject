using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;

namespace TmmProjectWPF.Commands.MainWindowCommands
{
    class ShowSelectionWorkCommand : ICommand
    {
        private MainWindowViewModel mainViewModel;

        public ShowSelectionWorkCommand(MainWindowViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.ShowSelectionWork();
        }
    }
}
