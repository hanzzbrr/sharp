using System;
using System.Threading;
using System.Threading.Tasks;

namespace async
{
    class Program
    {
        static void Main(string[] args)
        {            
            Task.Run(async () => 
            {
                System.Console.WriteLine((await DoWorkAsync()));
            });
            
            Console.WriteLine("Hello World!");

            Console.WriteLine(" Fun With Async ===>");
            Console.WriteLine(DoWork());
            Console.WriteLine("Completed");
            Console.ReadLine();


        }

        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() => 
            {
                Thread.Sleep(3_500);
                return "async Work is done!";
            });
        }
        static string DoWork()
        {
            Thread.Sleep(5000);
            return "Done With Work";
        }
    }
}
