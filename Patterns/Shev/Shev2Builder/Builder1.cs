class Builder1 : IBuilder
{
    string style = "abstract";
    Product product = new Product();

    public void BuildPartA()
    {
        product.Add("Part A " + style);
    }

    public void BuildPartB()
    {
        product.Add("Part B " + style);
    }

    public void BuildPartC()
    {
        product.Add("Part C " + style);
    }

    public Product GetResult()
    {
        return product;
    }
}