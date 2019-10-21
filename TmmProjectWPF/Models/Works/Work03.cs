using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TmmProjectWPF.Models.Works
{
    public class Work03 : INotifyPropertyChanged
    {
        #region Fields
        private decimal _L_ab;
        public decimal L_ab
        {
            get { return _L_ab; }
            set
            {
                _L_ab = value;
                OnPropertyChanged("L_ab");
            }
        }

        private decimal _L_bc;
        public decimal L_bc
        {
            get { return _L_bc; }
            set
            {
                _L_bc = value;
                OnPropertyChanged("L_bc");
            }
        }

        private decimal _L_bd;
        public decimal L_bd
        {
            get { return _L_bd; }
            set
            {
                _L_bd = value;
                OnPropertyChanged("L_bd");
            }
        }

        private decimal _L_a;
        public decimal L_a
        {
            get { return _L_a; }
            set
            {
                _L_a = value;
                OnPropertyChanged("L_a");
            }
        }

        
        private decimal _m2;

        public decimal m2
        {
            get { return _m2; }
            set
            {
                _m2 = value;
                OnPropertyChanged("m2");
            }
        }

        
        private decimal _m3;

        public decimal m3
        {
            get { return _m3; }
            set
            {
                _m3 = value;
                OnPropertyChanged("m3");
            }
        }


        private decimal _m4;

        public decimal m4
        {
            get { return _m4; }
            set
            {
                _m4 = value;
                OnPropertyChanged("m4");
            }
        }


        private decimal _Fc;

        public decimal Fc
        {
            get { return _Fc; }
            set
            {
                _Fc = value;
                OnPropertyChanged("Fc");
            }
        }


        private int _fi_v;

        public int fi_v
        {
            get { return _fi_v; }
            set
            {
                _fi_v = value;
                OnPropertyChanged("fi_v");
            }
        }


        private int _fi_dv;

        public int fi_dv
        {
            get { return _fi_dv; }
            set
            {
                _fi_dv = value;
                OnPropertyChanged("fi_dv");
            }
        }


        private int _fi_pov;

        public int fi_pov
        {
            get { return _fi_pov; }
            set
            {
                _fi_pov = value;
                OnPropertyChanged("fi_pov");
            }
        }

        #endregion

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
