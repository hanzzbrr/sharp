using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFMacDonaldCommands
{
    public class DataCommands
    {
        private static RoutedUICommand requery;
        public static RoutedUICommand Requery
        {
            get { return requery; }
        }
        static DataCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "CTRL  +R"));
            requery = new RoutedUICommand("Requery", "Requery", typeof(DataCommands), inputs);
        }

    }
}
