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

namespace WPF
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> objects = new List<string>() { "Cranebays", "StorageArea", "ProductionLines","Cars" };
        public List<string> objContent = new List<string>() { "This is cranebay data", "This is StorageArea data", "This is ProductionLines data", "This is Cars data" };

        public MainWindow()
        {
            InitializeComponent();
            //int last=0;
            foreach (var elem in objects) {
                comboBoxObjects.Items.Add(elem);
            }
            comboBoxObjects.SelectedItem = comboBoxObjects.Items[0];

        }

        private void comboBoxObjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            Console.WriteLine(cmb.SelectedItem.ToString());
            Handle();
        }
        private void Handle()
        {
            switch (comboBoxObjects.SelectedIndex)
            {
                case 0:
                    Console.WriteLine("out cranebays");
                    cbText.Text = objContent[0];
                    break;
                case 1:
                    Console.WriteLine("out StorageArea");
                    cbText.Text = objContent[1];
                    break;
                case 2:
                    Console.WriteLine("out prodlines");
                    cbText.Text = objContent[2];
                    break;
                case 3:
                    Console.WriteLine("out cars");
                    cbText.Text = objContent[3];
                    break;
                default:
                    break;
            }
        }
    }
}

