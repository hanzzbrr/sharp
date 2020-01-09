using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{

    class Program
    {
        static int x;
        static object locker = new object();
        static void Main()
        {
            Thread t = Thread.CurrentThread;


            

            for (int i=1; i<9; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Thread" + i;
                myThread.Start();
            }

            

            Console.ReadLine();

            
        }

        
        public static void Count()
        {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                lock (locker)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} : delta : {x++}");
                    Thread.Sleep(100);
                }
                }
        }
    }
}
