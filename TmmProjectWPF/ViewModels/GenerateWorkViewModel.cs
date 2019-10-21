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
        {   get { return ColumnsFormation("L_");    }   }

        public List<TableColumns> MassColumnsFormation
        { get { return ColumnsFormation("m"); } }

        public List<TableColumns> AnglesColumnsFormation
        { get { return ColumnsFormation("fi"); } }


        private List<TableColumns> ColumnsFormation(string stringStartsWithColumn )
        {
            var list = new List<TableColumns>();

            DataRow row = DataBase.Row(dataZ.Table, _selectionWork.VariantId);

            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName.StartsWith(stringStartsWithColumn))
                    list.Add
                        (new TableColumns()
                        {
                            Name = col.ColumnName, Value = row[col.ColumnName]
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
