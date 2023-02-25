class Builder2 : IBuilder
{
    string style = "Stone";
    Product product = new Product();
    public void BuildPartA()
    {
        product.Add(style + " part A");
    }

    public void BuildPartB()
    {
        product.Add(style + " part B");
    }

    public void BuildPartC()
    {
        product.Add(style + " part C");
    }

    public Product GetResult()
    {
        return product;
    }
}