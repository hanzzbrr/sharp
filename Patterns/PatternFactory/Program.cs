using System;

namespace PatternFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var point1 = PointFM.NewCartPoint(2, 2);
            var point2 = PointFM.NewPolarPoint(4,2);
        }
    }

    //Point with Factory Method pattern
    public class PointFM
    {
        private double x,y;
        public PointFM(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static PointFM NewCartPoint(double x, double y)
        {
            return new PointFM(x,y);
        }

        public static PointFM NewPolarPoint(double rho, double theta)
        {
            return new PointFM(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }
    }

    public class PointFactory
    {
        public static PointFM NewCarPoint(float x, float y) => new PointFM(x,y);
        public static PointFM NewPolarPoint(float rho, float theta) 
        => 
        new PointFM(rho * Math.Cos(theta), rho * Math.Sin(theta));
    }
}
