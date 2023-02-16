public class Ellipse : Shape
{
    public Ellipse(ILogger logger) : base(logger)
    {
        
    }

    protected override void DisplayShape()
    {
        Logger.Log($"Ellipse at position {base.Position} of size: {base.Size}");
    }

    public override Ellipse Clone()
    {
        Ellipse e = new(this.Logger)
        {
            Position = this.Position,
            Size = this.Size
        };
        return e;
    }
}