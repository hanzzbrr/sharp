class Adaptee
{
    public void SpecificRequest()
    {
        System.Console.WriteLine("SpecificRequest");
    }

    public void SpecificInterfaceMethod() =>
        System.Console.WriteLine("Specific interfacne method");
}