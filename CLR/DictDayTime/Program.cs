using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictDayTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2015, 7, 20);
            Day day1 = new Day();
            day1.tasks = new List<DayTask>(3);
            day1.tasks.Add(new DayTask("покушать"));
            day1.tasks.Add(new DayTask("фильмчик"));
            day1.tasks.Add(new DayTask("магаизны"));
            Data.days.Add(date1, day1);



            DateTime date2 = new DateTime(2016, 8, 25);
            Day day2 = new Day();
            day2.tasks = new List<DayTask>(2);
            day2.tasks.Add(new DayTask("aaa"));
            day2.tasks.Add(new DayTask("bbb"));
            Data.days.Add(date2, day2);

            DateTime compareDate = new DateTime(2016, 7, 20);
            Console.WriteLine(Data.days[date1]);
            Console.WriteLine(Data.days[date2]);

            if(Data.days.ContainsKey(compareDate))
                Console.WriteLine(Data.days[compareDate]);
            else
                Console.WriteLine("Ключ " + compareDate + " не содержится в словаре");





            Console.ReadLine();
        }
    }
}
