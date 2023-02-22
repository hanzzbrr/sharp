// 1. Ref keyword
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// SomeData data1 = new () { Value = 1 };
// Func(data1);
// System.Console.WriteLine($"new Value without ref: {data1.Value}");

// SomeData data2 = new () { Value = 1 };
// FuncRef(ref data2);
// System.Console.WriteLine($"new Value with ref: {data2.Value}");

// void Func(SomeData data)
// {
//     data.Value = 2;
//     data = new SomeData { Value = 3 };
// }

// void FuncRef(ref SomeData data)
// {
//     data.Value = 2;
//     data = new SomeData { Value = 3 };
// }

// public class SomeData
// {
//     public int Value { get; set;}
// }


// 2. by value by reference
// AStruct x1 = new AStruct { A = 1};  
// AStruct x2 = x1;                    // x1.A is 1; x2.A is 1; 
// x2.A = 2;                           // x1.A is 1; x2.A is 2; because of struct
// System.Console.WriteLine($"original is not affected: {x1.A}");

// AClass y1 = new AClass { B = 1};
// AClass y2 = y1;
// y2.B = 2;
// System.Console.WriteLine($"original is affected: {y1.B}");

// public struct AStruct
// {
//     public int A;
// }

// public class AClass
// {
//     public int B;
// }


// // tuples
// var t1 = ( Number: 1, String: "a");
// var t2 = t1;
// t2.Number = 2;
// t2.String = "b";
// System.Console.WriteLine($"didnt change with a tuple: {t1.Number} {t1.String}");

// object o = new Object();
// System.Console.WriteLine(nameof(Object));


// --------- UNSAFE --------------
// unsafe
// {
//     System.Console.WriteLine($"size of struct Point: {sizeof(Point)}");
// }

// System.Console.WriteLine($"size of int: {sizeof(int)}");

// public readonly struct Point
// {
//     public Point(int x, int y) => (X, Y) = (x, y);

//     public int X { get; }
//     public int Y { get; }
//     public int Z { get; }
// }


// // --------- type conversion, byte + byte overflow -----------
// byte value22 = 2;
// byte value33 = 12;
// // there could be a byte overflow
// // so byte + byte returns int
// object value44 = value22 + value33; 
// System.Console.WriteLine($"is value44 of byte type?: {value44 is byte}");   // false
// System.Console.WriteLine($"is value44 of int type?: {value44 is int}");     // int

// int value1 = -2;
// uint value2 = 0;
// value2 = unchecked((uint)value1);

// System.Console.WriteLine($"uint value after explicit conversion: {value2}");
// System.Console.WriteLine($"uint max value is: {uint.MaxValue}");


// int value3 = -1;
// char value4 = (char)value3;
// System.Console.WriteLine($"char value is: {value4}");
// System.Console.WriteLine($"char max value is: {char.MaxValue}");
// System.Console.WriteLine($"char max value integer value: {(int)char.MaxValue}");
// System.Console.WriteLine($"size of char: {sizeof(char)}");


// System.Console.WriteLine($"size of int: {sizeof(int)}");
// System.Console.WriteLine($"size of long {sizeof(long)}");


// // long longValue = 3000000000;
// // int i = checked((int)longValue);
// // System.Console.WriteLine($"after conversion from long: {i}");

// byte b = byte.MaxValue;
// checked
// {
//     b++;
// }
// System.Console.WriteLine($"byte value is: {b}");



// // ------------------------- null coalescending op. (not finished yet)
// Person? p = new Person{Name = "Hagrid"};
// void ShowPerson(Person? person)
// {
//     string firstName = person?.Name;
//     System.Console.WriteLine($"firstName is: {firstName}");
// }

// public class Person
// {
//     public string Name { get; set; }
// }


// // ----- Nullable<int>
// Nullable<int> x1 = null;
// ABStruct x2 = new ABStruct
// {
//     A = 0,
//     B = 1
// };

// public struct ABStruct
// {
//     public int A { get; set; }
//     public int B { get; set; }
// }