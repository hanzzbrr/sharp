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

namespace WPFMacDonaldCommands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ////создание привязки, пока-что объект биндинг существует сам по себе (классический шарп)
            ////для "движка" WPF binding пока является пустым местом
            //CommandBinding binding = new CommandBinding(ApplicationCommands.New);
            //binding.Executed += NewCommand_Executed;
            ////теперь WPF знает о существовании binding, вернее даже знает о новом CommandBinding обладающем индивид. чертами binding
            //this.CommandBindings.Add(binding);
        }

        void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("new com triggered by " + e.Source.ToString());
        }


        private bool isDirty = false;
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isDirty = true;
        }
        void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("save command is triggered now" + e.Source.ToString());
        }
        void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        void RequeryCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Requery command is Executed");
        }
    }

}
