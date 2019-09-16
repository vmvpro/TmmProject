using System;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.Commands
{
    public class ShowStudentViewCommand : ICommand
    {
        StudentViewModel studentViewModel;
        StudentView studentView;

        public ShowStudentViewCommand(StudentView studentView)
        {
            this.studentView = studentView;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        

        public void Execute(object parameter)
        {
            studentView.Show();
        }
    }
}
