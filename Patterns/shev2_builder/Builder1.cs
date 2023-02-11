class Builder1 : IBuilder
{
    Product product = new Product();

    public void BuildPartA()
    {
        product.Add("Part A");
    }

    public void BuildPartB()
    {
        product.Add("Part B");
    }

    public void BuildPartC()
    {
        product.Add("Part C");
    }

    public Product GetResult()
    {
        return product;
    }
}