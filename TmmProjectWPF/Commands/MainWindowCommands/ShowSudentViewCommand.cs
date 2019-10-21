using System;
using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.Commands.MainWindowCommands
{
    public class ShowStudentViewCommand : ICommand
    {
        private MainWindowViewModel mainViewModel;

        public ShowStudentViewCommand(MainWindowViewModel mainViewModel)
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
            mainViewModel.ShowStudent();
        }
    }
}
