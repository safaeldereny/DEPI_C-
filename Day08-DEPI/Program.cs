using System;

#region Problem 01
// interface IVehicle
// {
//     void StartEngine();  
//     void StopEngine();  
// }

// class Car : IVehicle
// {
//     public void StartEngine()
//     {
//         Console.WriteLine("Car engine started.");
//     }

//     public void StopEngine()
//     {
//         Console.WriteLine("Car engine stopped.");
//     }
// }
// class Bike : IVehicle
// {
//     public void StartEngine()
//     {
//         Console.WriteLine("Bike engine started.");
//     }

//     public void StopEngine()
//     {
//         Console.WriteLine("Bike engine stopped.");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         IVehicle myCar = new Car();
//         IVehicle myBike = new Bike();

//         myCar.StartEngine();
//         myCar.StopEngine();

//         myBike.StartEngine();
//         myBike.StopEngine();
//     }
// }
#endregion

#region Problem 02
// abstract class Shape
// {
//     public abstract double GetArea();

//     public void Display()
//     {
//         Console.WriteLine("This is a shape.");
//     }
// }

// class Rectangle : Shape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public Rectangle(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }

//     public override double GetArea()
//     {
//         return Width * Height;
//     }
// }

// class Circle : Shape
// {
//     public double Radius { get; set; }

//     public Circle(double radius)
//     {
//         Radius = radius;
//     }

//     public override double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }
// interface IShape
// {
//     double GetArea();
// }

// class RectangleShape : IShape
// {
//     public double Width { get; set; }
//     public double Height { get; set; }

//     public RectangleShape(double width, double height)
//     {
//         Width = width;
//         Height = height;
//     }

//     public double GetArea()
//     {
//         return Width * Height;
//     }
// }

// class CircleShape : IShape
// {
//     public double Radius { get; set; }

//     public CircleShape(double radius)
//     {
//         Radius = radius;
//     }

//     public double GetArea()
//     {
//         return Math.PI * Radius * Radius;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Abstract Class Approach");
//         Shape rect = new Rectangle(4, 5);
//         Shape circ = new Circle(3);

//         rect.Display();
//         Console.WriteLine("Rectangle area: " + rect.GetArea());

//         circ.Display();
//         Console.WriteLine("Circle area: " + circ.GetArea());

//         Console.WriteLine("\nInterface Approach");
//         IShape rectShape = new RectangleShape(4, 5);
//         IShape circShape = new CircleShape(3);

//         Console.WriteLine("Rectangle area (interface): " + rectShape.GetArea());
//         Console.WriteLine("Circle area (interface): " + circShape.GetArea());
//     }
// }

#endregion

#region Problem 03
// class Product : IComparable<Product>
// {
//     // Attributes / Properties
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Price { get; set; }

//     // Constructor
//     public Product(int id, string name, double price)
//     {
//         Id = id;
//         Name = name;
//         Price = price;
//     }

//     public int CompareTo(Product other)
//     {
//         if (other == null)
//             return 1;

//         if (this.Price > other.Price)
//             return 1;
//         else if (this.Price < other.Price)
//             return -1;
//         else
//             return 0;
//     }
//     public override string ToString()
//     {
//         return $"Id: {Id}, Name: {Name}, Price: {Price}";
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Product[] products = new Product[]
//         {
//             new Product(1, "Laptop", 1500),
//             new Product(2, "Mouse", 25),
//             new Product(3, "Keyboard", 45),
//             new Product(4, "Monitor", 300)
//         };

//         Console.WriteLine("Before Sorting:");
//         foreach (var p in products)
//         {
//             Console.WriteLine(p);
//         }
//         Array.Sort(products);

//         Console.WriteLine("\nAfter Sorting by Price (Ascending):");
//         foreach (var p in products)
//         {
//             Console.WriteLine(p);
//         }
//     }
// }

#endregion

#region Problem 04
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Grade { get; set; }
//     public Student(int id, string name, double grade)
//     {
//         Id = id;
//         Name = name;
//         Grade = grade;
//     }

//     public Student(Student other)
//     {
//         Id = other.Id;
//         Name = String.Copy(other.Name);
//         Grade = other.Grade;
//     }

//     // Override ToString for easy display
//     public override string ToString()
//     {
//         return $"Id: {Id}, Name: {Name}, Grade: {Grade}";
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         Student original = new Student(1, "Alice", 95);
//         Console.WriteLine("Original Student:");
//         Console.WriteLine(original);

//         Student shallowCopy = original;
//         shallowCopy.Name = "Bob";
//         Console.WriteLine("\nAfter modifying shallow copy:");
//         Console.WriteLine("Original: " + original);
//         Console.WriteLine("Shallow Copy: " + shallowCopy);

//         Student deepCopy = new Student(original);
//         deepCopy.Name = "Charlie"; 
//         deepCopy.Grade = 88;
//         Console.WriteLine("\nAfter modifying deep copy:");
//         Console.WriteLine("Original: " + original);
//         Console.WriteLine("Deep Copy: " + deepCopy);
//     }
// }

#endregion

#region Problem 05
// interface IWalkable
// {
//     void Walk();
// }

// class Robot : IWalkable
// {
//     public void Walk()
//     {
//         Console.WriteLine("Robot is walking using its default method.");
//     }

//     void IWalkable.Walk()
//     {
//         Console.WriteLine("Robot is walking as an IWalkable interface method.");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Robot myRobot = new Robot();

//         myRobot.Walk();

//         IWalkable walkableRobot = myRobot;
//         walkableRobot.Walk();
//     }
// }

#endregion

#region Problem 06
// struct Account
// {
//     // Private fields (encapsulation)
//     int accountId;
//     string accountHolder;
//     double balance;

//     public int AccountId
//     {
//         get { return accountId; }
//         set { accountId = value; }
//     }

//     public string AccountHolder
//     {
//         get { return accountHolder; }
//         set { accountHolder = value; }
//     }

//     public double Balance
//     {
//         get { return balance; }
//         set
//         {
//             if (value >= 0)
//                 balance = value;
//             else
//                 Console.WriteLine("Balance cannot be negative.");
//         }
//     }
//     public Account(int id, string holder, double initialBalance)
//     {
//         accountId = id;
//         accountHolder = holder;
//         balance = (initialBalance >= 0) ? initialBalance : 0;
//     }
//     public void Display()
//     {
//         Console.WriteLine($"Account ID: {AccountId}");
//         Console.WriteLine($"Account Holder: {AccountHolder}");
//         Console.WriteLine($"Balance: {Balance}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Account acc = new Account(101, "Alice", 5000);

//         Console.WriteLine("Original Account:");
//         acc.Display();

//         acc.Balance += 2000;
//         acc.AccountHolder = "Alice Smith";

//         Console.WriteLine("\nAfter Modifications:");
//         acc.Display();

//         acc.Balance = -100;
//     }
// }

#endregion

#region Problem 07
// class Book
// {
//     public string Title { get; set; }
//     public string Author { get; set; }

//     public Book()
//     {
//         Title = "Unknown Title";
//         Author = "Unknown Author";
//         Console.WriteLine("Default constructor called.");
//     }

//     public Book(string title)
//     {
//         Title = title;
//         Author = "Unknown Author";
//         Console.WriteLine("Constructor with Title called.");
//     }

//     public Book(string title, string author)
//     {
//         Title = title;
//         Author = author;
//         Console.WriteLine("Constructor with Title and Author called.");
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Title: {Title}, Author: {Author}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Book book1 = new Book();
//         book1.Display();

//         Console.WriteLine();

//         Book book2 = new Book("The Great Gatsby");
//         book2.Display();

//         Console.WriteLine();

//         Book book3 = new Book("1984", "George Orwell");
//         book3.Display();
//     }
// }

#endregion

#region Problem 08
// interface IShapeSeries
// {
//     int CurrentShapeArea { get; set; }
//     void GetNextArea();

//     void ResetSeries();
// }
// class SquareSeries : IShapeSeries
// {
//     private int sideLength = 1;

//     public int CurrentShapeArea { get; set; } = 0;

//     public void GetNextArea()
//     {
//         CurrentShapeArea = sideLength * sideLength;
//         sideLength++;
//     }

//     public void ResetSeries()
//     {
//         sideLength = 1;
//         CurrentShapeArea = 0;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         IShapeSeries series = new SquareSeries();

//         Console.WriteLine("First 5 squares in the series:");
//         for (int i = 0; i < 5; i++)
//         {
//             series.GetNextArea();
//             Console.WriteLine($"Square {i + 1} area: {series.CurrentShapeArea}");
//         }

//         series.ResetSeries();
//         Console.WriteLine("\nSeries reset.");
//         Console.WriteLine($"Current area after reset: {series.CurrentShapeArea}");
//     }
// }

#endregion

#region Problem 09
// interface IShapeSeries
// {
//     int CurrentShapeArea { get; set; }
//     void GetNextArea();
//     void ResetSeries();
// }
// class SquareSeries : IShapeSeries
// {
//     private int sideLength = 1; 

//     public int CurrentShapeArea { get; set; } = 0;

//     public void GetNextArea()
//     {
//         CurrentShapeArea = sideLength * sideLength;
//         sideLength++;
//     }

//     public void ResetSeries()
//     {
//         sideLength = 1;
//         CurrentShapeArea = 0;
//     }
// }
// class CircleSeries : IShapeSeries
// {
//     private int radius = 1;

//     public int CurrentShapeArea { get; set; } = 0;

//     public void GetNextArea()
//     {
//         CurrentShapeArea = (int)Math.Round(Math.PI * radius * radius);
//         radius++;
//     }

//     public void ResetSeries()
//     {
//         radius = 1;
//         CurrentShapeArea = 0;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         IShapeSeries squareSeries = new SquareSeries();
//         IShapeSeries circleSeries = new CircleSeries();

//         Console.WriteLine("First 5 squares in the series:");
//         for (int i = 0; i < 5; i++)
//         {
//             squareSeries.GetNextArea();
//             Console.WriteLine($"Square {i + 1} area: {squareSeries.CurrentShapeArea}");
//         }

//         Console.WriteLine("\nFirst 5 circles in the series:");
//         for (int i = 0; i < 5; i++)
//         {
//             circleSeries.GetNextArea();
//             Console.WriteLine($"Circle {i + 1} area: {circleSeries.CurrentShapeArea}");
//         }

//         squareSeries.ResetSeries();
//         circleSeries.ResetSeries();
//         Console.WriteLine("\nSeries reset:");
//         Console.WriteLine($"Square area after reset: {squareSeries.CurrentShapeArea}");
//         Console.WriteLine($"Circle area after reset: {circleSeries.CurrentShapeArea}");
//     }
// }
#endregion

#region Problem 10
// interface IShapeSeries
// {
//     int CurrentShapeArea { get; set; }
//     void GetNextArea();
//     void ResetSeries();
// }
// class SquareSeries : IShapeSeries
// {
//     private int sideLength = 1;

//     public int CurrentShapeArea { get; set; } = 0;

//     public void GetNextArea()
//     {
//         CurrentShapeArea = sideLength * sideLength;
//         sideLength++;
//     }

//     public void ResetSeries()
//     {
//         sideLength = 1;
//         CurrentShapeArea = 0;
//     }
// }
// class CircleSeries : IShapeSeries
// {
//     private int radius = 1;

//     public int CurrentShapeArea { get; set; } = 0;

//     public void GetNextArea()
//     {
//         CurrentShapeArea = (int)Math.Round(Math.PI * radius * radius);
//         radius++;
//     }

//     public void ResetSeries()
//     {
//         radius = 1;
//         CurrentShapeArea = 0;
//     }
// }
// class Program
// {
//     static void PrintTenShapes(IShapeSeries series)
//     {
//         series.ResetSeries(); 
//         for (int i = 1; i <= 10; i++)
//         {
//             series.GetNextArea();
//             Console.WriteLine($"Shape {i} area: {series.CurrentShapeArea}");
//         }
//         Console.WriteLine();
//     }

//     static void Main(string[] args)
//     {
//         IShapeSeries squareSeries = new SquareSeries();
//         IShapeSeries circleSeries = new CircleSeries();

//         Console.WriteLine("First 10 squares:");
//         PrintTenShapes(squareSeries);

//         Console.WriteLine("First 10 circles:");
//         PrintTenShapes(circleSeries);
//     }
// }
#endregion

#region Problem 11
// class Shape : IComparable<Shape>
// {
//     public string Name { get; set; }
//     public double Area { get; set; }

//     // Constructor
//     public Shape(string name, double area)
//     {
//         Name = name;
//         Area = area;
//     }
//     public int CompareTo(Shape other)
//     {
//         if (other == null) return 1;
//         return Area.CompareTo(other.Area);
//     }
//     public void Display()
//     {
//         Console.WriteLine($"{Name}: {Area}");
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Shape[] shapes = new Shape[]
//         {
//             new Shape("Square", 16),    // 4x4
//             new Shape("Circle", 28.27), // radius 3, area ~π*3²
//             new Shape("Rectangle", 20), // 4x5
//             new Shape("Square", 9),     // 3x3
//             new Shape("Circle", 78.54)  // radius 5, area ~π*5²
//         };

//         Console.WriteLine("Shapes before sorting:");
//         foreach (Shape s in shapes)
//         {
//             s.Display();
//         }
//         Array.Sort(shapes);

//         Console.WriteLine("\nShapes after sorting by area (ascending):");
//         foreach (Shape s in shapes)
//         {
//             s.Display();
//         }
//     }
// }
#endregion

#region Problem 12
// abstract class GeometricShape
// {
//     public double Dimension1 { get; set; }
//     public double Dimension2 { get; set; }

//     public GeometricShape(double dim1, double dim2)
//     {
//         Dimension1 = dim1;
//         Dimension2 = dim2;
//     }
//     public abstract double CalculateArea();
//     public abstract double Perimeter { get; }
//     public void Display()
//     {
//         Console.WriteLine($"Shape: {this.GetType().Name}");
//         Console.WriteLine($"Dimensions: {Dimension1}, {Dimension2}");
//         Console.WriteLine($"Area: {CalculateArea()}");
//         Console.WriteLine($"Perimeter: {Perimeter}\n");
//     }
// }
// class Triangle : GeometricShape
// {
//     public Triangle(double baseLength, double height) 
//         : base(baseLength, height) { }

//     public override double CalculateArea()
//     {
//         return 0.5 * Dimension1 * Dimension2;
//     }
//     public override double Perimeter
//     {
//         get
//         {
//             double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
//             return Dimension1 + Dimension2 + hypotenuse;
//         }
//     }
// }
// class Rectangle : GeometricShape
// {
//     public Rectangle(double length, double width)
//         : base(length, width) { }

//     public override double CalculateArea()
//     {
//         return Dimension1 * Dimension2;
//     }

//     public override double Perimeter
//     {
//         get
//         {
//             return 2 * (Dimension1 + Dimension2);
//         }
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         GeometricShape triangle = new Triangle(3, 4); // base=3, height=4
//         GeometricShape rectangle = new Rectangle(5, 6); // length=5, width=6

//         triangle.Display();
//         rectangle.Display();
//     }
// }
#endregion

#region Problem 13
// abstract class GeometricShape
// {
//     public double Dimension1 { get; set; }
//     public double Dimension2 { get; set; }

//     public GeometricShape(double dim1, double dim2)
//     {
//         Dimension1 = dim1;
//         Dimension2 = dim2;
//     }

//     public abstract double CalculateArea();
//     public abstract double Perimeter { get; }
// }

// class Triangle : GeometricShape
// {
//     public Triangle(double baseLength, double height) : base(baseLength, height) { }

//     public override double CalculateArea() => 0.5 * Dimension1 * Dimension2;

//     public override double Perimeter
//     {
//         get
//         {
//             double hypotenuse = Math.Sqrt(Dimension1 * Dimension1 + Dimension2 * Dimension2);
//             return Dimension1 + Dimension2 + hypotenuse;
//         }
//     }
// }
// class Rectangle : GeometricShape
// {
//     public Rectangle(double length, double width) : base(length, width) { }

//     public override double CalculateArea() => Dimension1 * Dimension2;

//     public override double Perimeter => 2 * (Dimension1 + Dimension2);
// }
// class Program
// {
//     public static void SelectionSort(int[] numbers)
//     {
//         int n = numbers.Length;

//         for (int i = 0; i < n - 1; i++)
//         {
//             int minIndex = i;

//             for (int j = i + 1; j < n; j++)
//             {
//                 if (numbers[j] < numbers[minIndex])
//                     minIndex = j;
//             }

//             int temp = numbers[i];
//             numbers[i] = numbers[minIndex];
//             numbers[minIndex] = temp;
//         }
//     }

//     static void Main(string[] args)
//     {
//         GeometricShape triangle = new Triangle(3, 4); // area = 6
//         GeometricShape rectangle = new Rectangle(5, 6); // area = 30
//         GeometricShape triangle2 = new Triangle(6, 2); // area = 6
//         GeometricShape rectangle2 = new Rectangle(2, 8); // area = 16

//         int[] areas = new int[]
//         {
//             (int)Math.Round(triangle.CalculateArea()),
//             (int)Math.Round(rectangle.CalculateArea()),
//             (int)Math.Round(triangle2.CalculateArea()),
//             (int)Math.Round(rectangle2.CalculateArea())
//         };

//         Console.WriteLine("Areas before sorting:");
//         foreach (int a in areas)
//             Console.WriteLine(a);

//         SelectionSort(areas);

//         Console.WriteLine("\nAreas after SelectionSort:");
//         foreach (int a in areas)
//             Console.WriteLine(a);
//     }
// }
#endregion







