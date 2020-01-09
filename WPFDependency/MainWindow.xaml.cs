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
using System.Windows.Threading;

namespace WPFDependency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter", typeof(int), typeof(MainWindow), new PropertyMetadata(25));
        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        public MainWindow()
        {
            
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                delegate
                {
                    int newvalue = 0;
                    if (Counter == int.MaxValue)    //обращаемся к CLR Property
                    {
                        newvalue = 0;
                    }
                    else
                    {
                        newvalue = Counter + 1;     //так же обращение к CLR Property
                    }
                    SetValue(CounterProperty, newvalue);    //
                },
                Dispatcher
                );
        }
    }
}
