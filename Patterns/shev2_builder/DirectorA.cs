class DirectorA
{
    IBuilder builder;

    public DirectorA(IBuilder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
    }
}