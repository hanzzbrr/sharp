using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorNumerable
{

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerator enumerator = "beer".GetEnumerator();
            while (enumerator.MoveNext())
            {
                var element = enumerator.Current;
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
