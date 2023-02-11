class Client
{
    dynamic factory;
    dynamic productA;
    dynamic productB;

    public Client(Factory factory)
    {
        string name = GetType().Namespace + "." + factory;
        this.factory = System.Activator.CreateInstance(System.Type.GetType(name));
        productA = this.factory.Make(Product.ProductA);
        productB = this.factory.Make(Product.ProductB);
    }

    public void Run()
    {
        productB.Interact(productA);
    }
}