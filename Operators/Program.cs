using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Elem el0 = new Elem(2, 4);
            Elem el1 = new Elem(4, 8);
            Elem el2 = el0 + el1;
            Elem el3 = el1 * el2;

            Console.WriteLine(el0);
            Console.WriteLine(el1);
            Console.WriteLine(el2);
            Console.WriteLine(el3);
            Console.ReadLine();
        }

        public class Elem
        {
            public int a, b;
            public int index;
            public static int count;
            public static Elem operator+(Elem e1, Elem e2)
            {
                return new Elem((e1.a+e2.a)/2, (e1.b+e2.b)/2);
            }
            public static Elem operator*(Elem e1, Elem e2)
            {
                return new Elem((e1.a*e2.a),(e1.b*e2.b));
            }
            public Elem(int a, int b)
            {
                this.a = a;
                this.b = b;
                index = count;
                count++;
            }
            public override string ToString()
            {
                return "el" + index + " : " + a + " " + b;
            }
        }
    }
}
