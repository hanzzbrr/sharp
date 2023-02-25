class Adapter : ITarget
{
    Adaptee adaptee = new Adaptee() { Name = "Some adapter"};

    public override void Request()
    {
        adaptee.SpecificRequest();
    }
}