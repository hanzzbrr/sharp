DependencyInjection();

void DependencyInjection()
{
    Ellipse e1 = new(new ConsoleLogger()) { Position = new(20,30), Size = new(100, 120) };
	e1.Draw();
}