using System;
using System.Text.RegularExpressions;

namespace RegexExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "+7z8z";
            Regex rgx = new Regex(@"^(\+?\d{1,3}|\d{1,4})$");  
            System.Console.WriteLine(rgx.IsMatch(value));

        }
    }
}
