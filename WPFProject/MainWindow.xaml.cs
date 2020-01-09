using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WPFProject
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

    public class SimpleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show("hello mccker");
        }
    }
    public class SimpleCommand1 : ICommand
    {
        public event EventHandler CanExecuteChanged;

        int count = 0;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            count++;
            MessageBox.Show("something happens, its all simple!");
            Console.WriteLine(count);
        }
    }

    public class ViewModelBase
    {
        public SimpleCommand SimpleCommand { get; set; }
        public SimpleCommand1 SimpleCommand1 { get; set; }
        public ViewModelBase()
        {
            this.SimpleCommand = new SimpleCommand();
            this.SimpleCommand1 = new SimpleCommand1();
        }
    }

}
