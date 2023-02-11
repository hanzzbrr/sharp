public class Program
{
    public static void Main(string[] args)
    {
        Prototype prototype = null;
        Prototype clone = null;

        prototype = new ConcretePrototype1(1, "Concrete");
        clone = prototype.Clone();

        System.Console.WriteLine($"Prototype is:\t {prototype.ToString()}");
        System.Console.WriteLine($"Clone is:\t {clone.ToString()}");

        prototype = new ConcretePrototype2(2, "NotConcrete");
        clone = prototype.Clone();

        System.Console.WriteLine($"Prototype is:\t {prototype.ToString()}");
        System.Console.WriteLine($"Clone is:\t {clone.ToString()}");
    }
}