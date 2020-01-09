using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace WPFObservable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> phones;
        public MainWindow()
        {
            InitializeComponent();

            phones = new ObservableCollection<string> {"I6s plus","Nexus 6P", "Galaxy s7 edge" };
            phonesList.ItemsSource = phones;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string phone = phoneTextBox.Text;
            phones.Add(phone);
        }
    }
}
