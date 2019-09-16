using System;
using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.Commands
{
    public class ShowStudentViewCommand : ICommand
    {
        StudentViewModel studentViewModel;
        
        public ShowStudentViewCommand(StudentViewModel studentViewModel)
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
