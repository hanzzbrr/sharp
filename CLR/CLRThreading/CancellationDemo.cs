using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CLRThreading
{
    class CancellationDemo
    {
        public CancellationDemo()
        {
            CancellationTokenSource cts = new CancellationTokenSource();

            ThreadPool.QueueUserWorkItem(o => Count(cts.Token, 18));

            Console.WriteLine("Press enter to cancel");
            Console.ReadLine();
            cts.Cancel();
            
            Console.ReadLine();
        }

        private void Count(CancellationToken token, Int32 countTo)
        {
            for(Int32 count = 0; count < countTo; count++)
            {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Count is cancelled");
                    break;
                }
                Console.WriteLine(count);
                Thread.Sleep(200);
            }
            Console.WriteLine("Count is done");
            
         
        }
    }
}
