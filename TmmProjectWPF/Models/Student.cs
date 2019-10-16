using System.ComponentModel;

namespace TmmProjectWPF.Models
{
    public class Student : INotifyPropertyChanged
    {
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

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
