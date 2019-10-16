using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class MainWindowViewModel
    {
        private StudentView studentView;
        
        public MainWindowViewModel()
        {
            ShowStudentCommand = new ShowStudentViewCommand(this);
        }

        public ICommand ShowStudentCommand { get; set; }

        public void ShowStudent()
        {
            studentView = new StudentView();
            studentView.Show();
        }

    }
}
