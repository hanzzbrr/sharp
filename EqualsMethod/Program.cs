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
