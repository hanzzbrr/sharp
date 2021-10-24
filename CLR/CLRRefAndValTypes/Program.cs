using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLRRefAndValTypes
{
    class SomeRef { public System.Int32 x; }
    struct SomeVal { public System.Int32 x; }

    class Program
    {
        static void ValueTypeDemo()
        {
            SomeRef r1 = new SomeRef(); // в куче
            SomeVal v1 = new SomeVal(); // в стеке
            r1.x = 5; // dereference указателя
            v1.x = 5; // изм. в стеке
            Console.WriteLine(r1.x);
            Console.WriteLine(v1.x);

            SomeRef r2 = r1; // копируем ссылку (указатель) на место в памяти
            SomeVal v2 = v1; // размещение в стеке, копирование членов
            r1.x = 8; //изменяются r1 и r2 т.к. указываем на одно место
            v1.x = 9; //изменяется только v1
            Console.WriteLine("Ссылка на одно место, r1.x = "+r1.x);
            Console.WriteLine("Ссылка на одно место, r2.x = " + r2.x);
            Console.WriteLine("v1.x = "+v1.x);
            Console.WriteLine("v2.x = "+ v2.x);
        }
        static void GetHasCodeTest()
        {
            Int16 myInt = 4;
            Console.WriteLine(myInt + " | " + myInt.GetHashCode());
            Int16 myInt1 = 5;
            Console.WriteLine(myInt1 + " | " + myInt1.GetHashCode());
            Int16 myInt2 = 6;
            Console.WriteLine(myInt2 + " | " + myInt2.GetHashCode());

        }

        static void Main(string[] args)
        {
            ValueTypeDemo();
            Console.WriteLine();
            GetHasCodeTest();



            Console.ReadLine();
        }
    }
}
