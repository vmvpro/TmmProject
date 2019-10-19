using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    public class GenerateWorkViewModel
    {
        SelectionWork _selectionWork;

        public GenerateWorkViewModel(SelectionWork selectionWork)
        {
            _selectionWork = selectionWork;

            generateCommand = new Command(Generate);
        }

        public int Work
        {
            get { return _selectionWork.WorkId; }
        }

        public int Variant
        {
            get { return _selectionWork.VariantId; }
        }

        //===========================================================

        #region Commands

        Command generateCommand;
        public Command GenerateCommand
        {
            get { return generateCommand; }
        }

        #endregion

        //===========================================================

        #region Methods

        public void Generate(object selWorkObj)
        {
            SelectionWork selWork = (SelectionWork)selWorkObj;

            //MessageBox.Show(selWork.WorkId + " - " + selWork.VariantId);


            //var generateWorkView = new GenerateWorkView(selWork);

            //generateWorkView.Show();


        }

        #endregion

    }
}
