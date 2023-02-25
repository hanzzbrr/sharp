class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if(request == 3)
            System.Console.WriteLine("Three");
        else if (Successor != null)
            Successor.HandleRequest(request);
    }
}