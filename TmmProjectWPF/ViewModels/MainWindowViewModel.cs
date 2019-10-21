using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Commands.MainWindowCommands;
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
            ShowSelectionWorkCommand = new ShowSelectionWorkCommand(this);

            testViewShowCommand = new Command(TestViewShow);
        }

        public ICommand ShowStudentCommand { get; set; }

        public ICommand ShowSelectionWorkCommand { get; set; }

        private Command testViewShowCommand;

        public Command TestViewShowCommand
        {
            get { return testViewShowCommand; }
        }


        private void TestViewShow(object param )
        {
            new TestView().Show();
        }

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
