class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if(request == 2)
            System.Console.WriteLine("Two");
        else if(Successor != null)
            Successor.HandleRequest(request);
    }
}