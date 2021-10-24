using System;
using System.Text;

namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new CodeBuilder();
            builder.AppendLine().Append("hello");
            System.Console.WriteLine(builder);
        }
    }
    
    public class CodeBuilder
    {
        private StringBuilder builder = new StringBuilder();
        private int indentLevel = 0;

        public CodeBuilder Indent()
        {
            indentLevel++;
            return this;
        }

        public CodeBuilder Append(string value)
        {
            builder.Append(value);
            return this;
        }

        public CodeBuilder AppendLine()
        {
            builder.AppendLine();
            return this;
        }

        public override string ToString() => builder.ToString();
    }
}
