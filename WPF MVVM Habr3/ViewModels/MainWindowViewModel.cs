using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_Habr3.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private string _synchronizedText;
        public string SynchronizedText {
            get
            {
                return _synchronizedText;
            }
            set
            {
                _synchronizedText = value;
                OnPropertyChanged(nameof(SynchronizedText));
            }
        }
    }
}
