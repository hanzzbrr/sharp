using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CLRThreading
{
    class QueueUserWorkItemExample
    {
        public QueueUserWorkItemExample()
        {
            Console.WriteLine("Main: queue");
            //ThreadPool.QueueUserWorkItem(ComputeBoundOp, 5);
            Task task = new Task(ComputeBoundOp, 5);
            task.Start();
            Console.WriteLine("Main: other work");
            Thread.Sleep(10000);
            Console.WriteLine("End prog");
            Console.ReadLine();
        }

        private void ComputeBoundOp(Object state)
        {
            Console.WriteLine("ComputeBoundOp: state={0}", state);
            Thread.Sleep(1000);
        }
    }
}
