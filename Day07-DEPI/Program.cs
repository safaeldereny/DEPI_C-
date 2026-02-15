using System;

#region Problem 01
// class Car
// {
//     // Properties
//     public int Id { get; set; }
//     public string Brand { get; set; }
//     public double Price { get; set; }

//     // 1. Default Constructor
//     public Car()
//     {
//         Id = 0;
//         Brand = "Unknown";
//         Price = 0.0;
//     }

//     // 2. Constructor with one parameter
//     public Car(int id)
//     {
//         Id = id;
//         Brand = "Unknown";
//         Price = 0.0;
//     }

//     // 3. Constructor with two parameters
//     public Car(int id, string brand)
//     {
//         Id = id;
//         Brand = brand;
//         Price = 0.0;
//     }

//     // 4. Constructor with three parameters
//     public Car(int id, string brand, double price)
//     {
//         Id = id;
//         Brand = brand;
//         Price = price;
//     }

//     // Method to display car info
//     public void Display()
//     {
//         Console.WriteLine($"Id: {Id}, Brand: {Brand}, Price: {Price}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Using default constructor
//         Car car1 = new Car();
//         car1.Display();

//         // Using constructor with one parameter
//         Car car2 = new Car(1);
//         car2.Display();

//         // Using constructor with two parameters
//         Car car3 = new Car(2, "Toyota");
//         car3.Display();

//         // Using constructor with three parameters
//         Car car4 = new Car(3, "BMW", 500000);
//         car4.Display();
//     }
// }
#endregion

#region Problem 02
// class Calculator
// {
  
//     public int Sum(int a, int b)
//     {
//         return a + b;
//     }

//     public int Sum(int a, int b, int c)
//     {
//         return a + b + c;
//     }

//     public double Sum(double a, double b)
//     {
//         return a + b;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Calculator calc = new Calculator();

//         int result1 = calc.Sum(5, 10);
//         Console.WriteLine("Sum of two integers: " + result1);

//         int result2 = calc.Sum(3, 4, 5);
//         Console.WriteLine("Sum of three integers: " + result2);

//         double result3 = calc.Sum(2.5, 3.7);
//         Console.WriteLine("Sum of two doubles: " + result3);
//     }
// }

#endregion

#region Problem 03
// class Parent
// {
//     public int X { get; set; }
//     public int Y { get; set; }

//     // Base constructor
//     public Parent(int x, int y)
//     {
//         X = x;
//         Y = y;
//         Console.WriteLine("Parent constructor called");
//     }
// }

// class Child : Parent
// {
//     public int Z { get; set; }

//     // Constructor chaining to base
//     public Child(int x, int y, int z) : base(x, y)
//     {
//         Z = z;
//         Console.WriteLine("Child constructor called");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Child obj = new Child(10, 20, 30);

//         Console.WriteLine($"X = {obj.X}");
//         Console.WriteLine($"Y = {obj.Y}");
//         Console.WriteLine($"Z = {obj.Z}");
//     }
// }
#endregion

#region Problem 04
// class Parent
// {
//     public int X { get; set; }
//     public int Y { get; set; }

//     public Parent(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
//     public virtual int Product()
//     {
//         return X * Y;
//     }
// }
// class ChildNew : Parent
// {
//     public int Z { get; set; }

//     public ChildNew(int x, int y, int z) : base(x, y)
//     {
//         Z = z;
//     }

//     public new int Product()
//     {
//         return X * Y * Z;
//     }
// }
// class ChildOverride : Parent
// {
//     public int Z { get; set; }

//     public ChildOverride(int x, int y, int z) : base(x, y)
//     {
//         Z = z;
//     }

//     public override int Product()
//     {
//         return X * Y * Z;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Testing NEW
//         Parent obj1 = new ChildNew(2, 3, 4);
//         Console.WriteLine("Using NEW: " + obj1.Product());

//         // Testing OVERRIDE
//         Parent obj2 = new ChildOverride(2, 3, 4);
//         Console.WriteLine("Using OVERRIDE: " + obj2.Product());
//     }
// }

#endregion

#region Problem 05
// class Parent
// {
//     public int X { get; set; }
//     public int Y { get; set; }

//     public Parent(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }
//     public override string ToString()
//     {
//         return $"({X}, {Y})";
//     }
// }

// class Child : Parent
// {
//     public int Z { get; set; }

//     public Child(int x, int y, int z) : base(x, y)
//     {
//         Z = z;
//     }
//     public override string ToString()
//     {
//         return $"({X}, {Y}, {Z})";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Parent p = new Parent(2, 3);
//         Parent c = new Child(4, 5, 6);   // Polymorphism

//         Console.WriteLine(p);
//         Console.WriteLine(c);
//     }
// }
#endregion

#region Problem 06

// interface IShape
// {
//     double Area { get; }    
//     void Draw();             
// }
// class Rectangle : IShape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }

//     public double Area
//     {
//         get { return Width * Height; }
//     }
//     public void Draw()
//     {
//         Console.WriteLine($"Drawing a rectangle {Width} x {Height}");
//     }
// }

// // Test program
// class Program
// {
//     static void Main()
//     {
//         IShape rect = new Rectangle(5, 10);

//         rect.Draw();
//         Console.WriteLine("Area: " + rect.Area);
//     }
// }

#endregion

#region Problem 07
// interface IShape
// {
//     double Area { get; }    
//     void Draw();            
//     void PrintDetails()
//     {
//         Console.WriteLine($"Shape details: Area = {Area}");
//         Draw();
//     }
// }

// class Circle : IShape
// {
//     public double Radius { get; set; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public double Area
//     {
//         get { return Math.PI * Radius * Radius; }
//     }
//     public void Draw()
//     {
//         Console.WriteLine($"Drawing a circle with radius {Radius}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         IShape circle = new Circle(5);

//         // Call default interface method
//         circle.PrintDetails();
//     }
// }

#endregion

#region Problem 08
// interface IMovable
// {
//     void Move();
// }
// class Car : IMovable
// {
//     public string Brand { get; set; }

//     public Car(string brand)
//     {
//         Brand = brand;
//     }

//     public void Move()
//     {
//         Console.WriteLine($"{Brand} is moving.");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         // Interface reference pointing to Car object
//         IMovable movableCar = new Car("Toyota");

//         // Call Move using the interface reference
//         movableCar.Move();
//     }
// }

#endregion

#region Problem 09
// interface IReadable
// {
//     void Read();
// }
// interface IWritable
// {
//     void Write();
// }
// class File : IReadable, IWritable
// {
//     public string FileName { get; set; }

//     public File(string fileName)
//     {
//         FileName = fileName;
//     }

//     public void Read()
//     {
//         Console.WriteLine($"Reading from file: {FileName}");
//     }

//     public void Write()
//     {
//         Console.WriteLine($"Writing to file: {FileName}");
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         File myFile = new File("data.txt");

//         // Using File object directly
//         myFile.Read();
//         myFile.Write();

//         // Using interface references
//         IReadable readableFile = myFile;
//         IWritable writableFile = myFile;

//         readableFile.Read();
//         writableFile.Write();
//     }
// }
#endregion

#region Problem 10
// abstract class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing Shape");
//     }
//     public abstract double CalculateArea();
// }

// // Derived class
// class Rectangle : Shape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }
//     public override void Draw()
//     {
//         Console.WriteLine($"Drawing Rectangle {Width} x {Height}");
//     }
//     public override double CalculateArea()
//     {
//         return Width * Height;
//     }
// }
// class Program
// {
//     static void Main()
//     {
//         Shape myRect = new Rectangle(5, 10);

//         // Call Draw
//         myRect.Draw();

//         // Call CalculateArea
//         Console.WriteLine("Area: " + myRect.CalculateArea());
//     }
// }
#endregion






























