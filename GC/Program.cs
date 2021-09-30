using System;

namespace GCExample
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Program myGCCal = new Program();
            System.Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

            myGCCal.MakeSomeGarbage();
            System.Console.WriteLine("Generation {0}", GC.GetGeneration(myGCCal));
            System.Console.WriteLine("Total memory, {0}", GC.GetTotalMemory(false));

            GC.Collect(0);

            System.Console.WriteLine("Generation {0}", GC.GetGeneration(myGCCal));
            System.Console.WriteLine("Total memory after collect 0 {0}", GC.GetTotalMemory(false));

            GC.Collect(2);

            System.Console.WriteLine("Generation {0}", GC.GetGeneration(myGCCal));
            System.Console.WriteLine("Total memory after collect 2 {0}", GC.GetTotalMemory(false));

        }

        
        private const long maxGarbage = 1000;
        void MakeSomeGarbage()
        {
            Version vt;
            for(int i=0; i < maxGarbage; i++)
            {
                vt = new Version();
            }
        }
    }
}
