using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Strategy Pattern");
            client.Run(new ConcreteA());
            client.Run(new ConcreteB());
            Console.ReadLine();
        }

        interface IStrategy { string GetMessage(); }
        class ConcreteA : IStrategy
        {
            public string GetMessage()
            {
                return "New message";
            }
        }
        class ConcreteB : IStrategy
        {
            public string GetMessage()
            {
                return "Message 2";
            }
        }
        class Client
        {
            public Client() { }
            public void Run(IStrategy strategy)
            {
                Console.WriteLine($"Message is:  {strategy.GetMessage()}");
            }
        }

        
    }
}
