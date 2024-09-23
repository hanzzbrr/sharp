using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalimskyDayPlanner
{
    public class LabelDayTime : Label
    {
        private int timeIndex;
        [Category("User"),Description("Time index of current dayTime Label.")]
        public int TimeIndex
        {
            get {return timeIndex; }
            set{timeIndex = value; }
        }
    }
}
