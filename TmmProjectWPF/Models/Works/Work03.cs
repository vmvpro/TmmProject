using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TmmProjectWPF.Models.DataAccess;


namespace TmmProjectWPF.Models.Works
{
    public class Work03 : INotifyPropertyChanged
    {
        public Work03(long variant)
        {
            var dataRow = DataBase.Row(variant, TableName.z3_data);
            this._L_ab = dataRow.Field<decimal>("L_ab");
            this._L_bc = dataRow.Field<decimal>("L_bc");
            this._L_bd = dataRow.Field<decimal>("L_bd");
            this._L_a = dataRow.Field<decimal>("L_a");
            this._m2 = dataRow.Field<decimal>("m2");
            this._m3 = dataRow.Field<decimal>("m3");
            this._m4 = dataRow.Field<decimal>("m4");

            this._Fc = dataRow.Field<decimal>("Fc");

            this._fi_v = dataRow.Field<long>("fi_v");
            this._fi_dv = dataRow.Field<long>("fi_dv");
            this._fi_pov = dataRow.Field<long>("fi_pov");
            
        }

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


        private long _fi_v;

        public long fi_v
        {
            get { return _fi_v; }
            set
            {
                _fi_v = value;
                OnPropertyChanged("fi_v");
            }
        }


        private long _fi_dv;

        public long fi_dv
        {
            get { return _fi_dv; }
            set
            {
                _fi_dv = value;
                OnPropertyChanged("fi_dv");
            }
        }


        private long _fi_pov;

        public long fi_pov
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
