using System;

namespace sharp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tuples
            (string name, int code) tuple1 = ("a", 1);
            System.Console.WriteLine($"{tuple1.name}, {tuple1.code}");

            var p = new Point(2.14, 3.15);
            (double X, double Y) = p;
            Console.WriteLine("x: ", X);
            Console.WriteLine(p);
            Console.WriteLine(FindMinMax(new int[] {0,2,15, 4}));

            // pattern mathcing
            int a = 4;
            int sum = 50;
            if(a is int count)
            {
                sum += count;
            }
            System.Console.WriteLine(sum);
        }

        static (int min, int max) FindMinMax(int[] input)
        {
            if(input is null || input.Length == 0)
            {
                throw new ArgumentException("  ");
            }

            var min = int.MaxValue;
            var max = int.MinValue;

            foreach(var i in input)
            {
                if(i < min)
                {
                    min = i;
                }
                if(i > max)
                {
                    max = i;
                }
            }
            return (min, max);
        }
    }



    public class Point
    {
        public Point(double x, double y) => (X, Y) = (x, y);

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y) =>  (x, y) = (X, Y);
    }
}
