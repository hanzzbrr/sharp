using System;

namespace sharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var person = new PersonModel(){Id = 1, FirstName = "Man", LastName = "Plus"};
        }
    }

    public class PersonModel
    {
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }    
    }
}
