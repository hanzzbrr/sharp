class Program
{
    public static void Main(string[] args)
    {
        IBuilder builder = new Builder1();
        Director director = new Director(builder);
        director.Construct();
        Product product = builder.GetResult();
        product.Show();
    }
}