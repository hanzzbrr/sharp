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
            Console.WriteLine("People class Example");
            People P1 = new People();
            P1.FirstName = "Simon";
            P1.LastName = "Tan";

            People P2 = new People();
            P2.FirstName = "Simon";
            P2.LastName = "Tan";

            Console.WriteLine(P1 == P2);
            Console.WriteLine(P1.Equals(P2));

            Console.WriteLine("hashcode p1: " + P1.GetHashCode());
            Console.WriteLine("hashcode p2: " + P2.GetHashCode());

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
            Console.WriteLine();

            Console.WriteLine("CLR VIA Class example");
            User usr1 = new User();
            usr1.Login = "Dave123";
            usr1.ID = 100;

            User usr2 = new User();
            usr2.Login = "Mustain51";
            usr2.ID = 110;

            User usr3 = new User();
            usr3.Login = "Dave123";
            usr3.ID = 100;


            User usr4 = new User();
            if(usr2 is User)
                usr4 = usr2;

            Console.WriteLine(usr1);
            Console.WriteLine(usr3);
            Console.WriteLine("usr1 == usr3? : "+(usr1 == usr3));
            Console.WriteLine("usr1 Equals usr3? : " + (usr1.Equals(usr3)));
            Console.WriteLine("usr1 RefEq usr3?: " + object.ReferenceEquals(usr1,usr3) + " - значения одинаковые, но место в памяти разное");
            Console.WriteLine();

            Console.WriteLine(usr2);
            Console.WriteLine(usr4);
            Console.WriteLine("usr2 == usr4? : " + (usr1 == usr3));
            Console.WriteLine("usr2 Equals usr4? : " + (usr2.Equals(usr4)));
            Console.WriteLine("usr2 RefEq usr4?: " + object.ReferenceEquals(usr2, usr4) + " - ссылаются на одно место");

            Admin adm1 = new Admin();
            adm1.Login = "Sonic";
            adm1.ID = 501;
            adm1.status = Admin.Status.Master;
            User usr5 = new User();
            usr5 = (User)(adm1 as User);

            Console.WriteLine(adm1 + " | " + adm1.GetType().ToString());
            Console.WriteLine(usr5 + " | " + usr5.GetType().ToString()); //почему usr5 выполняет ToString() производного класса Admin???


            Console.ReadLine();
        }
    }

    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            // если obj не People
            if (!(obj is People))
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

    public class User
    {
        public string Login { get; set; }
        public int ID;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is User)) return false;
            if (obj.GetType() != this.GetType()) return false;

            return this.Login == ((User)obj).Login && this.ID == ((User)obj).ID;
        }

        public override int GetHashCode()
        {
            return Login.GetHashCode() ^ ID.GetHashCode();
        }

        public override string ToString()
        {
            return this.Login + " | " + this.ID;
        }
    }

    public class Admin : User
    {
        public enum Status {Odmen, Master }
        public Status status;

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is User)) return false;
            if (obj.GetType() != this.GetType()) return false;

            return this.Login == ((User)obj).Login && this.ID == ((User)obj).ID && this.status == ((Admin)obj).status;
        }
        public override string ToString()
        {
            return base.ToString() + " | " + status.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.status.GetHashCode();
        }
    }
}
