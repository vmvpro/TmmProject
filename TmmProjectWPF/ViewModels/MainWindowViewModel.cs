using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class MainWindowViewModel
    {
        private StudentView studentView;
        private SelectionWorkView selectionWorkView;
        
        public MainWindowViewModel()
        {
            ShowStudentCommand = new ShowStudentViewCommand(this);
            ShowStudentCommand = new ShowStudentViewCommand(this);

            ShowSelectionWorkCommand = new ShowSelectionWorkCommand(this);
        }

        public ICommand ShowStudentCommand { get; set; }

        public ICommand ShowSelectionWorkCommand { get; set; }



        public void ShowStudent()
        {
            studentView = new StudentView();
            studentView.Show();
        }


        internal void ShowSelectionWork()
        {
            selectionWorkView = new SelectionWorkView();
            selectionWorkView.Show();
        }
    }
}
