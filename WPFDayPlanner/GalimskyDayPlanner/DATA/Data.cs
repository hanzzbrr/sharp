using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalimskyDayPlanner
{
    public static class Data
    {
        public static string dataDir;

        public static string date;
        public static DateTime dateTime;
        public static List<PhoneNumber> numbers = new List<PhoneNumber>();
        public static Dictionary<string,Day> days = new Dictionary<string,Day>(); //лист задач для каждого дня
    }
    public class Day 
    {
        public DateTime dateTime;
        public Dictionary<int,CalendTask> tasks; //задачи на день, их 19 штук


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var elem in tasks)
            {
                sb.Append(elem.Key + ":" + elem.Value +":"+elem.Value.IsDoneToString()+":"+ Environment.NewLine);
            }
            return sb.ToString();
        }
    }
    public class CalendTask: IComparable<CalendTask>
    {
        public string text;
        public bool isDone = false;

        public CalendTask(string text)
        {
            this.text = text;
            isDone = false;
        }

        public CalendTask(string text, bool isDone)
        {
            this.text = text;
            this.isDone = isDone;
        }

        public string IsDoneToString()
        {
            if (isDone)
                return "1";
            else
                return "0";
        }

        public int CompareTo(CalendTask other)
        {
            return this.text.CompareTo(other.text);
        }
        public override string ToString()
        {
            return text;
        }
    }
}
