using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class MainViewModel
    {
        private StudentView studentView; // = new StudentView();
        
        public MainViewModel()
        {
            ShowStudentCommand = new ShowStudentCommand(this);
        }

        public ICommand ShowStudentCommand { get; set; }

        public void ShowStudent()
        {
            studentView = new StudentView();
            studentView.Show();
        }

    }
}
