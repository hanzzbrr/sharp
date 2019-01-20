using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable mTable = new Hashtable();
            mTable.Add(100, "Bryan");
            mTable.Add(101, "Fargo");
            mTable.Add(99, "Cat");

            foreach(int ID in mTable.Keys)
                Console.WriteLine(ID);

            if(mTable.ContainsKey(101))
                Console.WriteLine(mTable[101]);//обращаемся по ключу используя [ ] 

            Console.ReadLine();
        }
    }
}
