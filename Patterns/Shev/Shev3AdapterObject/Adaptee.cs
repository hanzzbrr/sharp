class Adaptee
{
    public string Name { get; set; }
    public void SpecificRequest() =>
        System.Console.WriteLine($"Some specific request for {Name}");
}