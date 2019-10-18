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

            listSelectionWork = new List<SelectionWork>();

            for (int i = 0; i <= 9; i++)
            {
                //listSelectionWork.Add(new SelectionWork() { WorkId = i, VariantId = i });
                listSelectionWork.Add(new SelectionWork(workId: i, variantId: i));
            }
        }

        public List<SelectionWork> ListSelectionWork
        {
            get { return listSelectionWork; }
        }

        public IEnumerable<int> ListSelectionWorkAndVariant
        {
            get { return Enumerable.Range(0, 10); }
        }

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

        #endregion

        #region Methods

        public void MessageBoxParam(object test)
        {
            MessageBox.Show("TestCommand " + (int)test);
        }

        public void MessageBoxNotParam(object test)
        {
            MessageBox.Show("MessageBoxShowString ");
        }

        #endregion


    }


}
