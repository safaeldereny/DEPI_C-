using System;

#region Problem01
// enum Weekdays
// {
//     Monday = 1,
//     Tuesday,
//     Wednesday,
//     Thursday,
//     Friday
// }

// class Program
// {
//     static void Main()
//     {
//         foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
//         {
//             Console.WriteLine($"Day Name: {day}, Day Value: {(int)day}");
//         }
//     }
// }
#endregion
#region Problem02
// enum Grades : short
// {
//     F = 1,
//     D,
//     C,
//     B,
//     A
// }

// class Program
// {
//     static void Main()
//     {
//         foreach (Grades grade in Enum.GetValues(typeof(Grades)))
//         {
//             Console.WriteLine($"Grade Name: {grade}, Grade Value: {(short)grade}");
//         }
//     }
// }
#endregion
#region Problem03
// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Department { get; set; }

//     public Person(string name, int age, string department)
//     {
//         Name = name;
//         Age = age;
//         Department = department;
//     }

//     public void PrintDetails()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Instantiate two Person objects
//         Person person1 = new Person("Safa", 21, "Computer Science");
//         Person person2 = new Person("Ahmed", 30, "Human Resources");

//         person1.PrintDetails();
//         person2.PrintDetails();
//     }
// }
#endregion
#region Problem04
// class Parent
// {
//     public virtual double Salary { get; set; }
// }

// class Child : Parent
// {
//     // Sealed override
//     public sealed override double Salary { get; set; }

//     // Method that uses the sealed Salary property
//     public void DisplaySalary()
//     {
//         Console.WriteLine($"Salary is: {Salary}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Child employee = new Child();

//         employee.Salary = 10000;   // Assign value
//         employee.DisplaySalary();  // Call method
//     }
// }
#endregion
#region Problem05
// class Utility
// {
//     public static double CalculatePerimeter(double length, double width)
//     {
//         return 2 * (length + width);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         double perimeter = Utility.CalculatePerimeter(5, 3);

//         Console.WriteLine($"Perimeter of rectangle is: {perimeter}");
//     }
// }
#endregion
#region Problem06
// class ComplexNumber
// {
//     public double Real { get; set; }
//     public double Imaginary { get; set; }

//     public ComplexNumber(double real, double imaginary)
//     {
//         Real = real;
//         Imaginary = imaginary;
//     }

//     public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
//     {
//         double realPart = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
//         double imaginaryPart = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);

//         return new ComplexNumber(realPart, imaginaryPart);
//     }

//     public void Display()
//     {
//         Console.WriteLine($"{Real} + {Imaginary}i");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         ComplexNumber num1 = new ComplexNumber(2, 3);   // 2 + 3i
//         ComplexNumber num2 = new ComplexNumber(4, 5);   // 4 + 5i

//         ComplexNumber result = num1 * num2;

//         result.Display();
//     }
// }
#endregion
#region Problem07
// enum GenderDefault 
// {
//     Male,
//     Female
// }

// enum Gender : byte 
// {
//     Male,
//     Female
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine($"Size of GenderDefault (int): {sizeof(GenderDefault)} bytes");
//         Console.WriteLine($"Size of Gender (byte): {sizeof(Gender)} bytes");
//     }
// }
#endregion
#region Problem08
// class Utility
// {
//     public static double CelsiusToFahrenheit(double celsius)
//     {
//         return (celsius * 9 / 5) + 32;
//     }

//     public static double FahrenheitToCelsius(double fahrenheit)
//     {
//         return (fahrenheit - 32) * 5 / 9;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         double celsius = 25;
//         double fahrenheit = 77;

//         double result1 = Utility.CelsiusToFahrenheit(celsius);
//         double result2 = Utility.FahrenheitToCelsius(fahrenheit);

//         Console.WriteLine($"{celsius}°C = {result1}°F");
//         Console.WriteLine($"{fahrenheit}°F = {result2}°C");
//     }
// }
#endregion
#region Problem09
// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public Employee(int id, string name)
//     {
//         Id = id;
//         Name = name;
//     }

//     // Override Equals
//     public override bool Equals(object obj)
//     {
//         if (obj is Employee other)
//         {
//             return this.Id == other.Id;   // compare by Id
//         }
//         return false;
//     }
//     public override int GetHashCode()
//     {
//         return Id.GetHashCode();
//     }

//     public override string ToString()
//     {
//         return $"ID: {Id}, Name: {Name}";
//     }
// }

// class Helper2<T>
// {
//     public static int SearchArray(T[] array, T value)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i].Equals(value))
//                 return i;
//         }
//         return -1;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Employee[] employees =
//         {
//             new Employee(1, "Safa"),
//             new Employee(2, "Ahmed"),
//             new Employee(3, "Mona")
//         };

//         Employee target = new Employee(2, "Ahmed");

//         int index = Helper2<Employee>.SearchArray(employees, target);

//         if (index != -1)
//             Console.WriteLine($"Employee found at index {index}: {employees[index]}");
//         else
//             Console.WriteLine("Employee not found");
//     }
// }
#endregion
#region Problem10
// class Helper
// {
//     public static T Max<T>(T value1, T value2) where T : IComparable<T>
//     {
//         if (value1.CompareTo(value2) > 0)
//             return value1;
//         else
//             return value2;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Integers
//         int maxInt = Helper.Max(10, 20);
//         Console.WriteLine($"Max Integer: {maxInt}");

//         // Doubles
//         double maxDouble = Helper.Max(3.5, 7.2);
//         Console.WriteLine($"Max Double: {maxDouble}");

//         // Strings
//         string maxString = Helper.Max("Ahmed", "Safa");
//         Console.WriteLine($"Max String: {maxString}");
//     }
// }
#endregion
#region Problem11
// class Helper2<T>
// {
//     // Generic method to replace all occurrences of oldValue with newValue
//     public static void ReplaceArray(T[] array, T oldValue, T newValue)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i].Equals(oldValue))
//             {
//                 array[i] = newValue;
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3, 2, 4, 2 };
//         Console.WriteLine("Original int array: " + string.Join(", ", numbers));
//         Helper2<int>.ReplaceArray(numbers, 2, 99);
//         Console.WriteLine("Modified int array: " + string.Join(", ", numbers));

//         string[] names = { "Safa", "Ahmed", "Safa", "Mona" };
//         Console.WriteLine("\nOriginal string array: " + string.Join(", ", names));
//         Helper2<string>.ReplaceArray(names, "Safa", "Laila");
//         Console.WriteLine("Modified string array: " + string.Join(", ", names));
//     }
// }
#endregion
#region Problem12
// struct Rectangle
// {
//     public double Length { get; set; }
//     public double Width { get; set; }

//     public Rectangle(double length, double width)
//     {
//         Length = length;
//         Width = width;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"Length: {Length}, Width: {Width}");
//     }
// }

// class Program
// {
//     static void Swap(ref Rectangle r1, ref Rectangle r2)
//     {
//         Rectangle temp = r1;
//         r1 = r2;
//         r2 = temp;
//     }

//     static void Main()
//     {
//         Rectangle rect1 = new Rectangle(5, 10);
//         Rectangle rect2 = new Rectangle(7, 14);

//         Console.WriteLine("Before swap:");
//         rect1.Display();
//         rect2.Display();

//         Swap(ref rect1, ref rect2);

//         Console.WriteLine("\nAfter swap:");
//         rect1.Display();
//         rect2.Display();
//     }
// }
#endregion
#region Problem13
// class Department
// {
//     public string Name { get; set; }

//     public Department(string name)
//     {
//         Name = name;
//     }

//     public override bool Equals(object obj)
//     {
//         if (obj is Department other)
//         {
//             return this.Name == other.Name;
//         }
//         return false;
//     }

//     public override int GetHashCode()
//     {
//         return Name.GetHashCode();
//     }

//     public override string ToString()
//     {
//         return Name;
//     }
// }

// class Employee
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public Department Department { get; set; }

//     public Employee(int id, string name, Department dept)
//     {
//         Id = id;
//         Name = name;
//         Department = dept;
//     }

//     public override bool Equals(object obj)
//     {
//         if (obj is Employee other)
//         {
//             return this.Department.Equals(other.Department);
//         }
//         return false;
//     }

//     public override int GetHashCode()
//     {
//         return Department.GetHashCode();
//     }

//     public override string ToString()
//     {
//         return $"ID: {Id}, Name: {Name}, Department: {Department}";
//     }
// }

// class Helper2<T>
// {
//     public static int SearchArray(T[] array, T value)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i].Equals(value))
//                 return i;
//         }
//         return -1;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Department csDept = new Department("Computer Science");
//         Department hrDept = new Department("Human Resources");

//         Employee[] employees = {
//             new Employee(1, "Safa", csDept),
//             new Employee(2, "Ahmed", hrDept),
//             new Employee(3, "Mona", csDept)
//         };

//         Employee searchTarget = new Employee(0, "", csDept); 
//         int index = Helper2<Employee>.SearchArray(employees, searchTarget);

//         if (index != -1)
//             Console.WriteLine($"Employee found at index {index}: {employees[index]}");
//         else
//             Console.WriteLine("Employee not found");
//     }
// }
#endregion
#region Problem14
// struct CircleStruct
// {
//     public double Radius { get; set; }
//     public string Color { get; set; }

//     public CircleStruct(double radius, string color)
//     {
//         Radius = radius;
//         Color = color;
//     }
// }

// class CircleClass
// {
//     public double Radius { get; set; }
//     public string Color { get; set; }

//     public CircleClass(double radius, string color)
//     {
//         Radius = radius;
//         Color = color;
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         CircleStruct cs1 = new CircleStruct(5, "Red");
//         CircleStruct cs2 = new CircleStruct(5, "Red");

//         Console.WriteLine("Struct comparison:");
        
//         Console.WriteLine("cs1.Equals(cs2): " + cs1.Equals(cs2)); 
//         Console.WriteLine();


//         CircleClass cc1 = new CircleClass(5, "Red");
//         CircleClass cc2 = new CircleClass(5, "Red");
//         CircleClass cc3 = cc1;

//         Console.WriteLine("Class comparison:");
//         Console.WriteLine("cc1 == cc2: " + (cc1 == cc2));          
//         Console.WriteLine("cc1.Equals(cc2): " + cc1.Equals(cc2)); 
//         Console.WriteLine("cc1 == cc3: " + (cc1 == cc3));          
//         Console.WriteLine("cc1.Equals(cc3): " + cc1.Equals(cc3)); 
// }}
#endregion
#region Problem01_Part2
// class Program
// {
//     static T[] ReverseArray<T>(T[] array)
//     {
//         T[] reversed = new T[array.Length];
//         for (int i = 0; i < array.Length; i++)
//         {
//             reversed[i] = array[array.Length - 1 - i];
//         }
//         return reversed;
//     }

//     static void Main()
//     {
//         int[] nums = { 1, 2, 3, 4 };
//         string[] words = { "apple", "banana", "cherry" };

//         var reversedNums = ReverseArray(nums);
//         var reversedWords = ReverseArray(words);

//         Console.WriteLine(string.Join(", ", reversedNums));
//         Console.WriteLine(string.Join(", ", reversedWords)); 
//     }
// }
#endregion
#region Problem02_Part2
// class GenericStack<T>
// {
//     private List<T> elements = new List<T>();

//     public void Push(T item) => elements.Add(item);

//     public T Pop()
//     {
//         if (elements.Count == 0) throw new InvalidOperationException("Stack is empty");
//         T item = elements[elements.Count - 1];
//         elements.RemoveAt(elements.Count - 1);
//         return item;
//     }

//     public T Peek()
//     {
//         if (elements.Count == 0) throw new InvalidOperationException("Stack is empty");
//         return elements[elements.Count - 1];
//     }

//     public int Count => elements.Count;
// }

// class Program
// {
//     static void Main()
//     {
//         var stack = new GenericStack<int>();
//         stack.Push(10);
//         stack.Push(20);
//         Console.WriteLine(stack.Peek()); 
//         Console.WriteLine(stack.Pop()); 
//         Console.WriteLine(stack.Pop()); 
//     }
// }
#endregion
#region Problem03_Part2
// class Program
// {
//     static void SwapElements<T>(T[] array, int index1, int index2)
//     {
//         T temp = array[index1];
//         array[index1] = array[index2];
//         array[index2] = temp;
//     }

//     static void Main()
//     {
//         int[] numbers = { 1, 2, 3 };
//         SwapElements(numbers, 0, 2);
//         Console.WriteLine(string.Join(", ", numbers)); 
//     }
// }
#endregion
#region Problem04_Part2
// class Program
// {
//     static T FindMax<T>(T[] array) where T : IComparable<T>
//     {
//         T max = array[0];
//         foreach (T item in array)
//         {
//             if (item.CompareTo(max) > 0)
//                 max = item;
//         }
//         return max;
//     }

//     static void Main()
//     {
//         int[] nums = { 10, 25, 7 };
//         string[] words = { "apple", "banana", "cherry" };

//         Console.WriteLine(FindMax(nums));
//         Console.WriteLine(FindMax(words)); 
//     }
// }
#endregion