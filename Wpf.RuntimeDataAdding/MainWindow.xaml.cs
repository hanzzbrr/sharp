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

namespace WPFRuntimeDataAdding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<string> users = new ObservableCollection<string>();
        private List<string> bufferUsers = new List<string>() {"Phantom", "Striker", "MK", "Moby" };
        private ObservableCollection<string> filters = new ObservableCollection<string>();
        public ObservableCollection<string> Users
        {
            get { return users; }
        }
        public MainWindow()
        {
            InitializeComponent();
            usersList.ItemsSource = users;
            users.Add("Admin");
            users.Add("Anonym");
            List<User> items = new List<User>();
            items.Add(new User() { Name = "John Doe", Age = 42 });
            items.Add(new User() { Name = "Jane Doe", Age = 39 });
            items.Add(new User() { Name = "Sammy Doe", Age = 13 });
            items.Add(new User() { Name = "Donna Doe", Age = 13 });
            boxFilter.ItemsSource = filters;
            filters.Add(String.Empty);
            filters.Add("John");
            filters.Add("Jane");
            filters.Add("Sammy");
            filters.Add("Donna");
            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;

        }

        private void boxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshFilter();
        }
        private void boxFilter_DropDownClosed(object sender, EventArgs e)
        {
            RefreshFilter();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNextUser();
        }
        private bool UserFilter(object item)
        {
            string checkString = boxFilter.Text;
            Console.WriteLine(checkString);
            if (String.IsNullOrEmpty(checkString))
                return true;
            else
                return ((item as User).Name.IndexOf(checkString, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void RefreshFilter()
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }

        int index = 0;
        private void AddNextUser()
        {
            users.Add(bufferUsers[index]);
            index++;
            if (index >= bufferUsers.Count)
            {
                index = 0;
            }
            OutUsersList();
        }
        private void OutUsersList()
        {
            foreach(var elem in users)
            {
                Console.WriteLine(elem);
            }
        }
    }

    public enum SexType { Male, Female };

    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }

}
