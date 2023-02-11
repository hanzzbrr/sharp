class ConcreteFactory2 : IAbstractFactory
{
    dynamic product;

    public dynamic Make(Product product)
    {
        string name = GetType().Namespace + "." + product + "2";

        this.product = System.Activator.CreateInstance(System.Type.GetType(name));

        return this.product;
    }
}