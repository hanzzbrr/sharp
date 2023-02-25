abstract class Prototype
{
    private static int IdCounter = 0;
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Prototype(string name)
    {
        IdCounter++;
        Id = IdCounter;
        this.Name = name;
    }

    public abstract Prototype Clone();

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}