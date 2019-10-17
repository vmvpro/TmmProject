using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TmmProjectWPF.Commands;

namespace TmmProjectWPF.ViewModels
{
    public class SelectionWorkViewModel
    {
        Command messageCommand;

        public SelectionWorkViewModel()
        {
            messageCommand = new Command(MessageBoxShow);
        }

        public Command MessageCommand
        {
            get { return messageCommand; }
        }

        public void MessageBoxShow()
        {
            MessageBox.Show("TestCommand");
        }

    }


}
