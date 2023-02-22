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

namespace _4binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
                Здесь происходит интересная рефлективная тема.
                Intellisense распознает имена txtValue и lblValue только после билда.
                Эти имена становятся доступны через рефлексию из готовых dll-сборок.
                Code-analyzer рефлективно, через названия типов, доступных в сборках
                получает доступ к собранным в результате билда именам.
            */

            Binding binding = new Binding("Text");  // присосались к проперти Text
            binding.Source = txtValue;  // указали источник
            lblValue.SetBinding(TextBlock.TextProperty, binding);   // приатачили биндинг к lbvalue
        }
    }
}
