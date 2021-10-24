using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<User> users = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User() { Name = "John Wick", Age = 30 });
            users.Add(new User() { Name="Blilllililili Jeeeean"});
            usersList.ItemsSource = users;
        }

        private void usersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User u = (User)usersList.SelectedItem;
            MessageBox.Show(u.ToString());
        }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
