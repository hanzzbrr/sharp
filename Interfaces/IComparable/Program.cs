class Program
{
    static void Main(String[] args)
    {
        List<Car> cars = new List<Car>();
        cars.Add(new Car
        {
            TopSpeed = 200,
            Weight = 1000
        });
        cars.Add(new Car
        {
            TopSpeed = 180,
            Weight = 1200
        });
        cars.Add(new Car
        {
            TopSpeed = 180,
            Weight = 800
        });

        System.Console.WriteLine("Before sort");
        foreach(var car in cars)
        {
            System.Console.WriteLine(car.ToString());
        }

        cars.Sort();
        
        System.Console.WriteLine("After sort");
        foreach(var car in cars)
        {
            System.Console.WriteLine(car.ToString());
        }
    }
}

class Car : IComparable
{
    public string Name { get; set; }
    public int TopSpeed { get; set; }
    public int Weight { get; set; }

    public int CompareTo(object obj)
    {
        Car otherCar = (Car)obj;

        if(this.Weight > otherCar.Weight)
            return 1;
        else if (this.Weight == otherCar.Weight)
            return 0;
        else
            return -1;
    }

    public override string ToString()
    {
        return $"{Name}: {TopSpeed}, {Weight}";
    }
}