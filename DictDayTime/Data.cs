using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDayTime
{
    public static class Data
    {
        public static Dictionary<DateTime, Day> days = new Dictionary<DateTime, Day>();
    }

    public class Day
    {
        public List<DayTask> tasks;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0; i < tasks.Count; i++)
            {
                sb.Append(tasks[i]+" ");
            }

            return sb.ToString();
        }

    }

    public class DayTask
    {
        private string task;
        public string Task { get { return task; }set{ task = value; } } 
        public DayTask(string task)
        {
            this.task = task;
        }
        public override string ToString()
        {
            return task;
        }
    }
}
