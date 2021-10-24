using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLREvents.Example;

namespace CLREvents
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MailManager mm = new MailManager();
            Fax fax1 = new Fax(mm,"Austria");
            Fax fax2 = new Fax(mm, "London");
            Fax fax3 = new Fax(mm, "Varshava");
            Pager pager1 = new Pager(mm, "John");
            Pager pager2 = new Pager(mm, "Sophia");

            mm.SimulateNewMail("Artur", "Anna", "New Album");
            mm.SimulateNewMail("Gosleng", "Emo", "New Movie!");
            

            /*
            PostManager pm = new PostManager();
            PostService post1 = new PostService(pm);
            PostService post2 = new PostService(pm);

            pm.SimulateNewPack("Andrew", "Lesley", "Clocks", "AmazonExpress");
            */

            Console.WriteLine("Enter for exit...");
            Console.ReadLine();
        }
    }
}
