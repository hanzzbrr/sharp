using System;
using System.Threading;

namespace ThreadSyncing
{
    class Program
    {
        static int x = 0;
        static object locker = new object();
        static void Main(string[] args)
        {

            for(int i=0; i<5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"Thread: {i}";
                myThread.Start();
            }            
        }

        static void Count()
        {
            lock(locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }
        }
    }
}
