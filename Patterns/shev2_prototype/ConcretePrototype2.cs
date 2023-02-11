class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(int id, string name) : base(id, name)
    {
        
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype2(Id, Name);
    }
}