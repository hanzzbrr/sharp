public class Program
{
    public static void Main(string[] args)
    {
        Piano p = new Piano()
        {
            Mark = 3.2F
        };

        GrandPiano gp = new GrandPiano()
        {
            Mark = 3.2f,
            Producer = "Schimmel"
        };

        int res1 = gp.CompareTo(p);
        int res2 = p.CompareTo(gp);

        System.Console.WriteLine($"res1: {res1}");
        System.Console.WriteLine($"res2: {res2}");
    }
}

public class Piano : IComparable<Piano>
{
    public float Mark { get; set; }

    public int CompareTo(Piano other)
    {
        if(object.ReferenceEquals(other, null))
            return 1;

        return Mark.CompareTo(other.Mark);
    }
}

public class GrandPiano : Piano
{
    public string Producer { get; set; }
}