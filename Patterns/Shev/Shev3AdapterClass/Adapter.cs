class Adapter : Adaptee, ITarget
{
    public void Request()
    {
        SpecificRequest();
    }

    public void OneMoreSpecificInterface() =>
        System.Console.WriteLine("One more specific interface");
}