using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    public class GenerateWorkViewModel
    {
        SelectionWork _selectionWork;

        public GenerateWorkViewModel(SelectionWork selectionWork)
        {
            _selectionWork = selectionWork;
        }

        public int Work
        {
            get { return _selectionWork.WorkId; }
        }

        public int Variant
        {
            get { return _selectionWork.VariantId; }
        }

    }
}
