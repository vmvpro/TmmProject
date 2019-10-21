using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;
using TmmProjectWPF.Models.DataAccess;
using TmmProjectWPF.Models.Works;

namespace TmmProjectWPF.ViewModels
{
    public class GenerateWorkViewModel
    {


        SelectionWork _selectionWork;
        Work03 work; 

        public GenerateWorkViewModel(SelectionWork selectionWork)
        {
            _selectionWork = selectionWork;

            work = new Work03(_selectionWork.VariantId);

            generateCommand = new Command(Generate);
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

            

            Data dataZ = DataBase.LoadData(TableName.z3);
            Data lstn = DataBase.LoadData(TableName.lstn);
            Data zd_student = DataBase.LoadData(TableName.zd_student);

            var currentWork = selWorkObj as object[];
            if (currentWork == null) return;

            

            string lastName = (string)currentWork[0];
            int year = Convert.ToInt32(currentWork[1]);
            //DataRow drDodatok2 = StoredProcedure.TableDodatok2(lastName, year);
            //int id_dodatok = (int)drDodatok2["id"];

        }

        #endregion

    }
}
