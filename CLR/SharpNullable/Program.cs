using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpNullable
{
    class Program
    {

        public static List<System.Tuple<int, bool>> list = new List<Tuple<int, bool>>();
        public static List<Tuple<int?, bool?>> list1 = new List<Tuple<int?, bool?>>();

        static void Main(string[] args)
        {
            bool? nullBool = null;

            Console.WriteLine((nullBool == null) + " : " + nullBool.ToString());
            nullBool = true;
            Console.WriteLine((nullBool == null) + " : " + nullBool.ToString());

            list.Add(Tuple.Create(4, false));
            list.Add(Tuple.Create(12, true));
            list.Add(Tuple.Create(15, false));
            foreach(var elem in list)
                Console.WriteLine(elem);

            list1.Add(Tuple.Create<int?, bool?>(null,null));
            list1.Add(Tuple.Create<int?, bool?>(null, true));
            list1.Add(Tuple.Create<int?, bool?>(5, true));
            list1.Add(Tuple.Create<int?, bool?>(null, true));

            foreach (var elem in list1)
                Console.WriteLine("elem value is: {0}",elem);

            list1[0] = Tuple.Create<int?, bool?>(55, null);
            foreach (var elem in list1)
                Console.WriteLine("elem value is: {0}", elem);




            Console.ReadLine();

        }
    }
}
