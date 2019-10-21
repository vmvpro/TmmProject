using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TmmProjectWPF.Commands;
using TmmProjectWPF.Models;

namespace TmmProjectWPF.ViewModels
{
    public class TestViewModel
    {
        //public ObservableColection<SelectionWork> test

        List<SelectionWork> listSelectionWork;

        Student st;

        public TestViewModel()
        {
            messageCommandNotParam = new Command(MessageBoxNotParam);

            messageCommandParam = new Command(MessageBoxParam);

            objectSelectionWorkCommand = new Command(ObjectSelectionWork);

            addedButtonsInCanvasCommand = new Command(AddedButtonsInCanvas);

            listSelectionWork = new List<SelectionWork>();

            for (int i = 0; i <= 9; i++)
            {
                //listSelectionWork.Add(new SelectionWork() { WorkId = i, VariantId = i });
                var obj = new SelectionWork(workId: i, variantId: i);
                listSelectionWork.Add(obj);
            }

            st = new Student("vmvpro");
            st.Age = 29;

        }

        public Student Student
        {
            get { return st; }
        }


        public IEnumerable<int> ListSelectionWorkAndVariant
        {
            get { return Enumerable.Range(0, 10); }
        }

        #region Commands

        Command messageCommandNotParam;
        public Command MessageCommandNotParam
        {
            get { return messageCommandNotParam; }
        }

        Command messageCommandParam;
        public Command MessageCommandParam
        {
            get { return messageCommandParam; }
        }

        Command objectSelectionWorkCommand;
        public Command ObjectSelectionWorkCommand
        {
            get { return objectSelectionWorkCommand; }
        }

        Command addedButtonsInCanvasCommand;
        public Command AddedButtonsInCanvasCommand
        {
            get { return addedButtonsInCanvasCommand; }
        }

        #endregion

        #region Methods

        public void AddedButtonsInCanvas(object test)
        {
            MessageBox.Show("AddedButtonsInCanvas");
        }

        public void MessageBoxParam(object test)
        {
            MessageBox.Show("TestCommand " + (int) test);
        }

        public void MessageBoxNotParam(object test)
        {
            MessageBox.Show("MessageBoxShowString ");
        }

        public void ObjectSelectionWork(object selWorkObj)
        {
            SelectionWork selWork = (SelectionWork)selWorkObj;

            MessageBox.Show(selWork.WorkId + " - " + selWork.VariantId);
        }

        

        #endregion


    }


}
