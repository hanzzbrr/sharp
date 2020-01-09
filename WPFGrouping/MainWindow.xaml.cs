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

namespace WPFGrouping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Item
    {
        public string Group { get; set; }
        public string Name { get; set; }
    }

    public class ViewModel
    {
        public ObservableCollection<Item> Collection { get; set; }
        public CollectionViewSource CollectionView { get; set; }
        public ViewModel()
        {
            this.Collection = new ObservableCollection<Item>
            {
                new Item { Group = "GroupA", Name = "Item 1" },
                new Item { Group = "GroupA", Name = "Item 2" },
                new Item { Group = "GroupA", Name = "Item 3" },
                new Item { Group = "GroupA", Name = "Item 4" },
                new Item { Group = "GroupA", Name = "Item 5" },
                new Item { Group = "GroupA", Name = "Item 6" },
                new Item { Group = "GroupB", Name = "Item 1" },
                new Item { Group = "GroupB", Name = "Item 2" },
                new Item { Group = "GroupB", Name = "Item 3" }
            };
            var view = new CollectionViewSource();
            view.GroupDescriptions.Add(new PropertyGroupDescription("Group"));
            view.Source = Collection;
            CollectionView = view;
        }
    }
}
