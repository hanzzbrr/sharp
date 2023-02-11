class ConcretePrototype2 : Prototype
{
    public ConcretePrototype2(string name) : base(name)
    {

    }

    public override Prototype Clone()
    {
        return new ConcretePrototype2(Name);
    }
}