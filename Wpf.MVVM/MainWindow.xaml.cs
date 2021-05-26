using System.Windows;
using WPFMVVMNetCore.ViewModel;

namespace WPFMVVMNetCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            UserViewModel VM = new UserViewModel();
            Application.Current.MainWindow.DataContext = new UserViewModel();
        }
    }
}
