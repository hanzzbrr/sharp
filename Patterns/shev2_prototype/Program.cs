public class Program
{
    public static void Main(string[] args)
    {
        Prototype prototype = null;
        List<Prototype> clones = new List<Prototype>();

        prototype = new ConcretePrototype1("Concrete");
        clones.Add(prototype.Clone());
        clones.Add(prototype.Clone());
        clones.Add(prototype.Clone());
        prototype = new ConcretePrototype2("NotConcrete");
        clones.Add(prototype.Clone());
        clones.Add(prototype.Clone());
        clones.Add(prototype.Clone());

        foreach(var item in clones)
        {
            System.Console.WriteLine($"Clone is: {item.ToString()}");
        }
    }
}