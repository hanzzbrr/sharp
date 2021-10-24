using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer() { ID = 101, NAME = "mark", Salary = 12000 };
            Customer cust2 = new Customer() { ID = 102, NAME = "pam", Salary = 7000 };
            Customer cust3 = new Customer() { ID = 103, NAME = "avraam", Salary = 9000 };
            List<Customer> customers = new List<Customer>();
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            Console.WriteLine("before sort");
            foreach(var elem in customers)
                Console.WriteLine(elem.ID + " | " + elem.NAME + " | " + elem.Salary);

            customers.Sort();
            Console.WriteLine("Sorting");
            foreach (var elem in customers)
                Console.WriteLine(elem.ID + " | " + elem.NAME + " | " + elem.Salary);

            SortCustomerByName sortCustomerByName = new SortCustomerByName();
            customers.Sort(sortCustomerByName); //.net doesnt know hot to sort list of this type, so we need to implement sorting

            Console.WriteLine("Sorting by name");
            foreach (var elem in customers)
                Console.WriteLine(elem.ID + " | " + elem.NAME + " | " + elem.Salary);

            SortCustomerByID sortCustomerByID = new SortCustomerByID();
            customers.Sort(sortCustomerByID);
            Console.WriteLine("sort by ID");
            foreach(var elem in customers)
                Console.WriteLine(elem.ID + " | " + elem.NAME + " | " + elem.Salary);

            SortCustomerBySalar sortCustomerBySalar = new SortCustomerBySalar();
            customers.Sort(sortCustomerBySalar);
            Console.WriteLine("sort by Salary");
            foreach (var elem in customers)
                Console.WriteLine(elem.ID + " | " + elem.NAME + " | " + elem.Salary);


            Console.ReadLine();
        }
    }

    public class SortCustomerByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.NAME.CompareTo(y.NAME);
        }
    }
    public class SortCustomerByID : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
    public class SortCustomerBySalar : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public int Salary { get; set; }

        //how we want our customer objects to be compared*
        public int CompareTo(Customer other)
        {
            return this.Salary.CompareTo(other.Salary);
        }
    }

}
