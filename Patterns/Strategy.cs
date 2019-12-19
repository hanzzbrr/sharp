using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
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
