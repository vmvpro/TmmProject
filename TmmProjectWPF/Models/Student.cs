using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TmmProjectWPF.Models
{
    public class Student : INotifyPropertyChanged
    {

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        
			

        private string name;
        public Student(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                //OnPropertyChanged(nameof(name));
                OnPropertyChanged("Name");
            }
        }
        
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
