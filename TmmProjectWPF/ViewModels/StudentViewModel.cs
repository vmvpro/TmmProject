using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Commands.StudentViewCommands;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    public class StudentViewModel
    {
        private Student student;

        public StudentViewModel()
        {
            student = new Student("VMVPRO");
            RenameNameCommand = new RenameNameCommand(this);
        }

        //public Student Student_ => student; 

        public Student Student
        {
            get { return student; }
        }

        public ICommand RenameNameCommand { get; set; }

        public void RenameName()
        {
            //Debug.Assert(false, $"Rename name {Student.Name}" );
            //Debug.Assert(false, String.Format("Rename name {0}", Student.Name));
            MessageBox.Show(student.Name);

        }

    }
}
