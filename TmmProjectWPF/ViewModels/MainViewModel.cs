using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class MainViewModel
    {
        StudentView studentView; // = new StudentView();
        StudentViewModel studentViewModel; // = new StudentView();

        public MainViewModel()
        {
            studentView = new StudentView();
            ShowStudentView = new ShowStudentViewCommand(studentViewModel);
        }

        ICommand ShowStudentView
        {
            get;
            set;
        }
     }
}
