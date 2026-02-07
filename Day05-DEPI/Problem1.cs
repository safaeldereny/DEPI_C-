// Problem: Write a program that: 
// o Reads two integers from the user and divides them. 
// o Catches DivideByZeroException and displays an appropriate message. 
// o Uses a finally block to print "Operation complete" regardless of success or failure.
using System;

class Problem1
{
    public static void Run()
    {
        try
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            int result = x / y;
            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Operation complete");
        }
    }
}
