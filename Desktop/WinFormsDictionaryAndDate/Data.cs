using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsDictionaryAndDate
{
    public static class Data
    {
        public static Dictionary<DateTime, DayTasks> days;
    }

    public class DayTasks
    {
        public DateTime date;
        public List<DayTask> tasks;
    }

    public class DayTask
    {
        public string task;
    }
}
