using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRThreading
{
    class TaskResultExample
    {
        public TaskResultExample()
        {
            Task<Int32> t = new Task<int>(n => Sum((Int32)n, "task0"), 500);
            t.Start();
            Task<Int32> t1 = new Task<int>(n => Sum((Int32)n, "task1"), 200);
            
            t1.Start();
            Task.WaitAny();
            //t.Wait();
            //t1.Wait();
            Console.WriteLine("The sum is " + t.Result);
            Console.WriteLine("The sum is " + t1.Result);
            Console.ReadLine();
        }

        private Int32 Sum(Int32 n, string name)
        {
            Int32 sum = 0;
            for (; n > 0; n--)
            {
                checked { sum += n; }
                Console.WriteLine(name +" : "+ sum);
            }
            return sum;
        }
    }
}
