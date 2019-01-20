using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            People P1 = new People();
            P1.FirstName = "Simon";
            P1.LastName = "Tan";

            People P2 = new People();
            P2.FirstName = "Simon";
            P2.LastName = "Tan";

            Console.WriteLine(P1 == P2);
            Console.WriteLine(P1.Equals(P2));

            Console.WriteLine("hashcode p1: " + P1.GetHashCode());
            Console.WriteLine("hashcode p2: "+ P2.GetHashCode());

            People P3 = new People();
            P3.FirstName = "Dan";
            P3.LastName = "Borisov";
            Console.WriteLine("hashcode p3: " + P3.GetHashCode());

            People P4 = new People();
            P4.FirstName = "A";
            P4.LastName = "C";
            Console.WriteLine("hashcode P4: " + P4.GetHashCode());

            People P5 = new People();
            P5.FirstName = "AB";
            P5.LastName = "BC";
            Console.WriteLine("hashcode P5: " + P5.GetHashCode());


            Console.ReadLine();
        }
    }

    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            // если obj не People
            if(!(obj is People))
            {
                return false;
            }

            return this.FirstName == ((People)obj).FirstName &&
                this.LastName == ((People)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
