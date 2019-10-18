using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TmmProjectWPF.Models
{
    public class SelectionWork : INotifyPropertyChanged
    {
        int _workId;
        public int WorkId
        {
            get { return _workId; }
            set
            {
                _workId = value;
                OnPropertyChanged("WorkId");
            }
        }

        int _variantId;
        public int VariantId 
        { 
            get { return _variantId; } 
            set 
            {
                _variantId = value;
                OnPropertyChanged("VariantId");
            } 
        }

        public SelectionWork(int workId, int variantId)
        {
            _workId = workId;
            _variantId = variantId;
        }

        //System.Collections.ObjectModel.ObservableCollection<>

        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
