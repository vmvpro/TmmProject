using System;
using System.Collections.Generic;
using System.Data;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;
using TmmProjectWPF.Models.DataAccess;
using TmmProjectWPF.Models.Works;

namespace TmmProjectWPF.ViewModels
{
    public class GenerateWorkViewModel
    {
        private SelectionWork _selectionWork = null;
        private Data dataZ;
        private DataRow rowZ = null;
        //Student _student;

        public GenerateWorkViewModel() { }
        
        public GenerateWorkViewModel(SelectionWork selectionWork)
        {
            _selectionWork = selectionWork;
            rowZ = _selectionWork.RowZ;

            _selectionWork.LenghtsColumnsFormation = ColumnsFormation(_selectionWork, new[] { "L_" });
            _selectionWork.MassColumnsFormation = ColumnsFormation(_selectionWork, new[] { "m", "Fc", "F_", "M_" });
            _selectionWork.AnglesColumnsFormation = ColumnsFormation(_selectionWork, new[] { "fi", "e", "y" });

            //dataZ = DataBase.LoadDataZD(_selectionWork.WorkId);
            //_student = new Student();

            generateCommand = new Command(Generate);
        }

        public SelectionWork SelectionWork
        {
            get { return _selectionWork; }
        }

        private List<TableColumns> ColumnsFormation(SelectionWork selectionWork, string[] StartsWithColumn)
        {
            List<TableColumns> list = new List<TableColumns>();

            //DataRow row = DataBase.Row(dataZ, VariantId);

            DataRow row = selectionWork.RowZ;

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

        //public List<TableColumns> LenghtsColumnsFormation;
        //{ get { return ColumnsFormation(new[] { "L_" }); } }

        //public List<TableColumns> MassColumnsFormation
        //{ get { return ColumnsFormation(new[] { "m", "Fc", "F_", "M_" }); } }

        //public List<TableColumns> AnglesColumnsFormation
        //{ get { return ColumnsFormation(new[] { "fi", "e", "y" } ); } }

        //public List<TableColumns> AnglesColumnsFormation
        //{ get { return ColumnsFormation(new[] { "fi", "e", "y" } ); } }

        //TableAdded2ColumnsFormation =
        //        ColumnsFormation(_selectionWork.DataRowDodatok2.Table, new[] { "w2", "delta", "h", "zi", "zm", "position_m" });







        //public int? WorkId
        //{
        //    get { return (_selectionWork != null) ? _selectionWork?.WorkId : null; }
        //}

        //public int? VariantId
        //{
        //    get { return (_selectionWork != null) ? _selectionWork?.VariantId : null; }
        //}

        //string lastName;
        //public string LastName
        //{
        //    get { return st.LastName; }
        //    set { lastName = value; }
        //}

        //===========================================================

        #region Commands

        private Command generateCommand;
        public Command GenerateCommand
        {
            get { return generateCommand; }
        }

        #endregion

        //===========================================================

        #region Methods
        
        public void Generate(object studentObject)
        {
            //Data dataZ = DataBase.LoadData(TableName.z3);
            Data lstn = DataBase.LoadData(TableName.lstn);
            Data zd_student = DataBase.LoadData(TableName.zd_student);

            Student student = studentObject as Student;
            if (student == null) return;

            _selectionWork.LastName = student.LastName;
            _selectionWork.Year = student.Year;

            DataRow drDodatok2 = StoredProcedure.TableDodatok2(_selectionWork.LastName, _selectionWork.Year);
            long id_dodatok = drDodatok2.Field<long>("id");

        }

        #endregion

    }
}
