using System.ComponentModel;

namespace WPFMVVMNetCore.Model
{
    public class User : INotifyPropertyChanged
    {

        private int _userId;
        private string _firstName;
        
        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                OnPropertyChanged("UserId");
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        #region Inotify
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
