using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy();
        }

        private static void Strategy()
        {
            Console.WriteLine("Strategy Pattern");
            Strategy.Client client = new Strategy.Client();
            client.Run(new Strategy.ConcreteA());
            client.Run(new Strategy.ConcreteB());
        }
    }
}


