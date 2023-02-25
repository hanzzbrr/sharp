class ProductB1 : IAbstractProductB
{
    public void Interact(IAbstractProductA a)
    {
        System.Console.WriteLine(this.GetType().Name + " взаимодействует с " + a.GetType().Name + " :)");
    }
}