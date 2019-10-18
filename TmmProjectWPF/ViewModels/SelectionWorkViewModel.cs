using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    public class SelectionWorkViewModel
    {
        //public ObservableColection<SelectionWork> test

        List<SelectionWork> listSelectionWork;

        public SelectionWorkViewModel()
        {
            messageCommandNotParam = new Command(MessageBoxNotParam);

            messageCommandParam = new Command(MessageBoxParam);

            objectSelectionWorkCommand = new Command(ObjectSelectionWork);
            
        }

        public IEnumerable<int> ListSelectionWorkAndVariant
        {
            get { return Enumerable.Range(0, 10); }
        }

        //===========================================================

        #region Commands

        Command messageCommandNotParam;
        public Command MessageCommandNotParam
        {
            get { return messageCommandNotParam; }
        }

        Command messageCommandParam;
        public Command MessageCommandParam
        {
            get { return messageCommandParam; }
        }

        Command objectSelectionWorkCommand;
        public Command ObjectSelectionWorkCommand
        {
            get { return objectSelectionWorkCommand; }
        }

        #endregion

        //===========================================================

        #region Methods

        public void MessageBoxParam(object test)
        {
            MessageBox.Show("TestCommand " + (int)test);
        }

        public void MessageBoxNotParam(object test)
        {
            MessageBox.Show("MessageBoxShowString ");
        }

        public void ObjectSelectionWork(object selWorkObj)
        {
            SelectionWork selWork = (SelectionWork)selWorkObj;

            MessageBox.Show(selWork.WorkId + " - " + selWork.VariantId);
        }

        #endregion


    }


}
