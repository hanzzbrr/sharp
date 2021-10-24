using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Wpf.CustomersDemo.ViewModel
{
    public class CustomerViewModel
    {
        RelayCommand _saveCommand; 
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new RelayCommand(param => this.Save(),
                        param => this.CanSave);
                }
                return _saveCommand;
            }
        }
    }
}
