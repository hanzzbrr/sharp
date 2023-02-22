public interface IService
{
    void Serve();
}

public class Service1 : IService
{
    public void Serve()
    {
        System.Console.WriteLine("Service1 called");
    }
}

public class Service2 : IService
{
    public void Serve()
    {
        System.Console.WriteLine("Service2 called");
    }
}

public class Client
{
    private IService _service;
    public Client(IService service)
    {
        this._service = service;
    }

    public void ServeMethod()
    {
        this._service.Serve();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IService s1 = new Service1();
        var c1 = new Client(s1);
        c1.ServeMethod();

        IService s2 = new Service2();
        c1 = new Client(s2);
        c1.ServeMethod();
    }
}