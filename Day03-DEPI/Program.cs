using System;
using System.Text;
using Microsoft.VisualBasic;
#region Problem 01
// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter your age:");
//         string age = Console.ReadLine();

//     try
//         {
//             int age1 = int.Parse(age);
//             Console.WriteLine("Using int.Parse:" +age1);

//             int age2 = Convert.ToInt32(age);
//             Console.WriteLine("Using Convert.ToInt32:" +age2);
//         }
//         catch (ArgumentNullException)
//         {
//             Console.WriteLine("Error: No input provided (null).");
//         }
//         catch (OverflowException)
//         {
//             Console.WriteLine("Error: Number is too large or too small for an int.");
//         }
//         finally
//         {
//             Console.WriteLine("Program finished.");
//         }
//     }
// }
#endregion
#region Problem 02
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a number: ");
//         string num = Console.ReadLine();
//         int the_number;
//         if (int .TryParse(num , out the_number))
//         {
//             Console.WriteLine("you entered :" + the_number);
//         }
//         else
//         {
//             Console.WriteLine("Error: Input is not a valid integer. ");
//         }
//     }
// }
#endregion
#region Problem 03
// class Program
// {
//     static void Main()
//     {
//         object obj;

//         // (int) 
//         obj = 44;
//         Console.WriteLine("Value : " + obj);
//         Console.WriteLine("GetHashCode(): "+obj.GetHashCode());
//         Console.WriteLine();

//         // (string) 
//         obj = "Hello";
//         Console.WriteLine("Value : " + obj);
//         Console.WriteLine("GetHashCode(): "+obj.GetHashCode());
//         Console.WriteLine();

//         // (double)   
//         obj = 32.15456;
//         Console.WriteLine("Value : " + obj);
//         Console.WriteLine("GetHashCode(): "+obj.GetHashCode());
//         Console.WriteLine();

//     }
// }
#endregion
#region Problem 04
// class Program
// {
//     static void Main()
//     {
//         My1obj obj1 = new My1obj();
//         obj1.Value = 10;
//         Console.WriteLine("Initial value of obj1 :" + obj1);

//         My2obj obj2 = obj1;
//         Console.WriteLine("Value of obj2: "+ obj2);

//         obj1.Value = 25;

//         Console.WriteLine("After modifying obj1, value of obj2: " + obj2.Value);
//     }
// }
#endregion
#region Problem 05
// class Program
// {
//     static void Main()
//     {
//         string str = "Hello!";

//         Console.WriteLine("Original string :" +str);
//         Console.WriteLine("GetHashCode before modification:" +str.GetHashCode());
//         Console.WriteLine();

//         str = str + "Hi Willy";

//         Console.WriteLine("Modified string: "+str);
//         Console.WriteLine("GetHashCode after modification:" +str.GetHashCode());
//     }
// }
#endregion
#region Problem 06
// class Program
// {
//     static void Main()
//     {
//         StringBuilder sb = new StringBuilder("Hi Willy");

//         Console.WriteLine("Original StringBuilder: " +sb);
//         Console.WriteLine("GetHashCode before modification: " +sb.GetHashCode());
//         Console.WriteLine();

//         sb.Append("How old are you?");

//         Console.WriteLine("Modified StringBuilder: "+ sb.ToString());
//         Console.WriteLine("GetHashCode after modification: " +sb.GetHashCode());
//     }
// }
#endregion
#region Problem 07
// class Program
// {
//     static void Main()
//     {
//     Console.Write("Enter first integer:");
//     int num1 = int.Parse(Console.ReadLine());

//     Console.Write("Enter second integer: ");
//     int num2 = int.Parse(Console.ReadLine());

//     int sum = num1 + num2;

//     Console.WriteLine("Usning concatenation : sum is " +sum);
//     Console.WriteLine(string.Format("Using composite formatting: sum is {0}" , sum));
//     Console.WriteLine($"Using string interpolation: Sum is {sum}");
//     }
// }
#endregion
#region Problem 08
// class Program
// {
//     static void Main()
//     {
//         StringBuilder sb = new StringBuilder("Hello world");
//         Console.WriteLine("Original StringBuilder: "+sb);

//         // Apped text 
//         sb.Append("! Welcome");
//         Console.WriteLine("After Append: "+sb);
        
//         // Replace a substring
//         sb.Replace("world" , "c#");
//         Console.WriteLine("After Replace: "+ sb);

//         // Insert a string at a specific position
//         sb.Insert(6 , "my");
//         Console.WriteLine("After Insert: "+sb);

//         // Remove a portion of text
//         sb.Remove(6 , 5);
//         Console.WriteLine("After Remove: "+ sb);

//     }
// }
#endregion











