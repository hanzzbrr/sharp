using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpTuple
{
    class Program
    {
        //Tuple<T1,T2,T3,T4> указан в качестве типа возвращаемого значения
        //Метод просто принимает два значения int и string и возвращает, созданный из них кортеж
        static Tuple<int,float, string, char> Cortege(int a, string name)
        {
            int sqr = a * a;    //приняли int a, получили int sqr
            float sqrt = (float)(Math.Sqrt(a)); //приняли int a, получили float sqrt
            string s = "Привет, " + name;   //приняли string name, получили string
            char ch = (char)(name[0]);  //приняли string name, получили char ch

            return Tuple.Create<int, float, string, char>(sqr, sqrt, s, ch);
        }
        static void Main(string[] args)
        {

            Tuple<int,float,string,char> myTuple = Cortege(25, "Alexander");
            Console.WriteLine("{0}, {1}, {2}, {3}", myTuple.Item1, myTuple.Item2, myTuple.Item3, myTuple.Item4);
            
            

            var myTuple2 = Tuple.Create<int, char, string, decimal, float, byte, short, Tuple<int, float, string, char>>(12, 'C', "name", 12.3892m, 0.5f, 120, 4501, myTuple);
            Console.WriteLine("{0}, {1}, {2}, {3}",myTuple2.Item1, myTuple2.Item2, myTuple2.Item3,myTuple2.Item4);

            

            
            Console.ReadLine();
        }
    }
}
