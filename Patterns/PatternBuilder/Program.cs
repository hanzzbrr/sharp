using System;
using System.Collections.Generic;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HtmlElement root = HtmlElement
            .Create("ul")
            .AddChild("li", "hello")
            .AddChild("li", "world");
            System.Console.WriteLine(root);
        }
    }

    class HtmlElement
    {
        public string Name, Text;
        public List<HtmlElement> Elements = new List<HtmlElement>();
        public const int indentSize = 2;
        public HtmlElement() {}
        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        public static HtmlBuilder Create (string rootName) => new HtmlBuilder(rootName);

        public override string ToString() => $"Name: {Name}, Text: {Text}";
    }

    class HtmlBuilder
    {
        protected readonly string rootName;
        protected HtmlElement root = new HtmlElement();

        public static implicit operator HtmlElement(HtmlBuilder builder)
        {
            return builder.root;
        }

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public override string ToString() => root.ToString();
    }
}
