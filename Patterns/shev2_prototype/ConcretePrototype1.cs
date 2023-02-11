class ConcretePrototype1 : Prototype
{
    public ConcretePrototype1(string name) : base(name)
    {
        
    }

    public override Prototype Clone()
    {
        return new ConcretePrototype1(Name);
    }
}