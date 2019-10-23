using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TmmProjectWPF.Models.DataAccess;

namespace TmmProjectWPF.Models
{
    public class SelectionWork : INotifyPropertyChanged
    {
        private Data dataZ;
        private DataRow row;
        public SelectionWork(int workId, int variantId)
        {
            _workId = workId;
            _variantId = variantId;

            dataZ = DataBase.LoadDataZD(_workId);
            row = DataBase.Row(dataZ.Table, _variantId);
        }

        /// <summary>
        /// Строка задания
        /// </summary>
        public DataRow RowZ
        {
            get { return row; }
        }

        private int _workId;
        public int WorkId
        {
            get { return _workId; }
            set
            {
                _workId = value;
                OnPropertyChanged("WorkId");
            }
        }

        private int _variantId;
        public int VariantId
        {
            get { return _variantId; }
            set
            {
                _variantId = value;
                OnPropertyChanged("VariantId");
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        private List<TableColumns> lenghtsColumnsFormation;
        public List<TableColumns> LenghtsColumnsFormation
        {
            get { return lenghtsColumnsFormation; }
            set
            {
                lenghtsColumnsFormation = value;
                OnPropertyChanged("LenghtsColumnsFormation");
            }
        }

        private List<TableColumns> massColumnsFormation;
        public List<TableColumns> MassColumnsFormation
        {
            get { return massColumnsFormation; }
            set
            {
                massColumnsFormation = value;
                OnPropertyChanged("MassColumnsFormation");
            }
        }

        private List<TableColumns> anglesColumnsFormation;
        public List<TableColumns> AnglesColumnsFormation
        {
            get { return anglesColumnsFormation; }
            set
            {
                anglesColumnsFormation = value;
                OnPropertyChanged("AnglesColumnsFormation");
            }
        }

        private List<TableColumns> tableAdded2ColumnsFormation;
        public List<TableColumns> TableAdded2ColumnsFormation
        {
            get { return tableAdded2ColumnsFormation; }
            set
            {
                tableAdded2ColumnsFormation = value;
                OnPropertyChanged("TableAdded2ColumnsFormation");
            }
        }



        #region -----   Methods   ------

        //private void DataZ()
        //{
        //    dataZ = DataBase.LoadDataZD(WorkId);
        //    DataRow row = DataBase.Row(dataZ.Table, VariantId);
        //}

        private List<TableColumns> ColumnsFormation(DataTable dataZ, string[] StartsWithColumn)
        {
            List<TableColumns> list = new List<TableColumns>();

            DataRow row = DataBase.Row(dataZ, VariantId);

            foreach (DataColumn col in row.Table.Columns)
            {
                foreach (string stringStartsWithColumn in StartsWithColumn)
                    if (col.ColumnName.StartsWith(stringStartsWithColumn))
                        list.Add
                            (new TableColumns()
                            {
                                Name = col.ColumnName.Replace("_", "__"),
                                Value = row[col.ColumnName]
                            });
            }

            return list;
        }
        #endregion


        #region INotifyPropertyChanged Member

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        
        //System.Collections.ObjectModel.ObservableCollection<>


    }
}
