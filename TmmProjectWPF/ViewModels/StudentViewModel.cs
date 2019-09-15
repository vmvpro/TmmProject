using System;
using System.Diagnostics;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    internal class StudentViewModel
    {
        private Student student;

        public StudentViewModel()
        {
            student = new Student("VMVPRO");
        }

        //public Student Student_ => student; 

        public Student Student
        {
            get { return student; }
        }

        public void RenameName()
        {
            //Debug.Assert(false, $"Rename name {Student.Name}" );
            Debug.Assert(false, String.Format("Rename name {0}", Student.Name));
        }

    }
}
