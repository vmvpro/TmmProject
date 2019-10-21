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
        private SelectionWork _selectionWork;
        private Work03 work;
        private Data dataZ;

        public GenerateWorkViewModel() { }

        public GenerateWorkViewModel(SelectionWork selectionWork)
        {
            _selectionWork = selectionWork;

            dataZ = DataBase.LoadDataZD(_selectionWork.WorkId);

            //work = new Work03(_selectionWork.VariantId);



            generateCommand = new Command(Generate);
        }

        public List<TableColumns> LenghtsColumnsFormation
        { get { return ColumnsFormation(new[] { "L_" }); } }

        public List<TableColumns> MassColumnsFormation
        { get { return ColumnsFormation(new[] { "m", "Fc", "F_", "M_" }); } }

        public List<TableColumns> AnglesColumnsFormation
        { get { return ColumnsFormation(new[] { "fi", "e", "y" } ); } }


        private List<TableColumns> ColumnsFormation(string[] StartsWithColumn)
        {
            List<TableColumns> list = new List<TableColumns>();

            DataRow row = DataBase.Row(dataZ.Table, _selectionWork.VariantId);

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

        public Work03 Work
        {
            get { return work; }
        }

        public int WorkId
        {
            get { return _selectionWork.WorkId; }
        }

        public int VariantId
        {
            get { return _selectionWork.VariantId; }
        }

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

        public void Generate(object selWorkObj)
        {




            //Data dataZ = DataBase.LoadData(TableName.z3);
            Data lstn = DataBase.LoadData(TableName.lstn);
            Data zd_student = DataBase.LoadData(TableName.zd_student);

            object[] currentWork = selWorkObj as object[];
            if (currentWork == null) return;



            string lastName = (string)currentWork[0];
            int year = Convert.ToInt32(currentWork[1]);
            //DataRow drDodatok2 = StoredProcedure.TableDodatok2(lastName, year);
            //int id_dodatok = (int)drDodatok2["id"];

        }

        #endregion

    }
}
