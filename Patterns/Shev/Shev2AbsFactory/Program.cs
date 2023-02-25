class Program
{
    public static void Main(string[] args)
    {
        Client client;
        client = new Client(Factory.ConcreteFactory1);
        client.Run();

        client = new Client(Factory.ConcreteFactory2);
        client.Run();
    }
}