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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf.Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            image.MouseDown += Image_MouseDown;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DoubleAnimation animate = new DoubleAnimation();
            animate.From = 1;            
            animate.To = 0;
            animate.Duration = new Duration(TimeSpan.FromSeconds(1));
            animate.Completed += Animate_Completed;
            image.BeginAnimation(Image.OpacityProperty, animate);            
        }

        private void Animate_Completed(object sender, EventArgs e)
        {
            
        }
    }
}
