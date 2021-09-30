using System;
using System.Collections.Generic;

namespace sharp8
{
    public interface ISomeInterface
    {
        public void SomeMethod ()
        {
            throw new NotImplementedException("Ex");
        }
    }

    public class SomeClass : ISomeInterface
    {
        public void SomeMethod()
        {
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // slices
            var places = new string[] {"fist", "second", "third", "fourth", "fifth"};

            System.Console.WriteLine(places[^1]);

            foreach(var item in places[2..4])
            {
                System.Console.WriteLine(item);
            }

            // null coalescing
            var example = new ListDemo();

            example.LuckyNumbers ??= new List<int>();

            var obj = new SomeClass();
            obj.SomeMethod();
        }
    }

    public class ListDemo
    {
        public List<int> LuckyNumbers { get; set; }
        public ListDemo()
        {

        }
    }
}
