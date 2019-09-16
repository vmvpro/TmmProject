using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class MainViewModel
    {
        private StudentView studentView; // = new StudentView();
        private StudentViewModel studentViewModel; // = new StudentView();

        public MainViewModel()
        {
            studentView = new StudentView();
            ShowStudentCommand = new ShowStudentCommand(studentView);
        }

        public ICommand ShowStudentCommand { get; set; }

        public void ShowStudent()
        {
            //studentView.Show();

            MessageBox.Show("ShowStudent");
        }

    }
}
