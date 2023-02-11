abstract class Prototype
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Prototype(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public abstract Prototype Clone();

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }
}