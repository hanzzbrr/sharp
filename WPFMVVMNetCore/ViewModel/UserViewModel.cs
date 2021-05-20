using System;
using System.Collections.Generic;
using System.Windows.Input;
using WPFMVVMNetCore.Model;

namespace WPFMVVMNetCore.ViewModel
{
    public class UserViewModel
    {
        private IList<User> _userList;

        public IList<User> Users
        {
            get => _userList;
            set => _userList = value;
        }

        public UserViewModel()
        {
            _userList = new List<User>()
            { 
                new User{UserId = 1, FirstName = "Boris"},
                new User{UserId = 2, FirstName = "Johns"}
            };
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
