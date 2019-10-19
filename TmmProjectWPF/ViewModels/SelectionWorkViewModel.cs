using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;
using TmmProjectWPF.Views;

namespace TmmProjectWPF.ViewModels
{
    public class SelectionWorkViewModel
    {
        //public ObservableColection<SelectionWork> test

        List<SelectionWork> listSelectionWork;

        public SelectionWorkViewModel()
        {
            objectSelectionWorkCommand = new Command(ObjectSelectionWork);
        }

        public IEnumerable<int> ListSelectionWorkAndVariant
        {
            get { return Enumerable.Range(0, 10); }
        }

        //===========================================================

        #region Commands

        Command objectSelectionWorkCommand;
        public Command ObjectSelectionWorkCommand
        {
            get { return objectSelectionWorkCommand; }
        }

        #endregion

        //===========================================================

        #region Methods

        public void ObjectSelectionWork(object selWorkObj)
        {
            SelectionWork selWork = (SelectionWork)selWorkObj;

            //MessageBox.Show(selWork.WorkId + " - " + selWork.VariantId);


            var generateWorkView = new GenerateWorkView(selWork);

            generateWorkView.Show();


        }

        #endregion


    }


}
