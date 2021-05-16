using System;

namespace Lambda
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation op =(x,y) => x + y;
            System.Console.WriteLine(op(10,20));
            System.Console.WriteLine(op(40, 20));

            op = (x,y) => x-y;
            System.Console.WriteLine(op(10, 20));
            System.Console.WriteLine(op(40,30));
            Console.Read();
        }
    }
}
