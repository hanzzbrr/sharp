using SimpleGC;
using System;

// create object in managed heap
Car refToMyCar = new Car("Zippy", 50);

System.Console.WriteLine(refToMyCar.ToString());