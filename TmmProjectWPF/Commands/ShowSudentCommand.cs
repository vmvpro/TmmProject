﻿using System;
using System.Windows;
using System.Windows.Input;
using TmmProjectWPF.ViewModels;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.Commands
{
    public class ShowStudentCommand : ICommand
    {
        StudentView studentView;
        
        public ShowStudentCommand(StudentView studentView)
        {
            this.studentView = studentView;
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
            studentView.Show();
        }
    }
}