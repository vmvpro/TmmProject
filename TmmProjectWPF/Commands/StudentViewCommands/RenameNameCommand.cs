using System;
using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.Commands
{
    public class RenameNameCommand : ICommand
    {
        StudentViewModel studentViewModel;
        
        public RenameNameCommand(StudentViewModel studentViewModel)
        {
            this.studentViewModel = studentViewModel;
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
            studentViewModel.RenameName();
        }
    }
}
