// Problem: Create a method that: 
// o Accepts a string and an optional integer (default value: 5). 
// o Prints the string the specified number of times. 
// o Demonstrates the use of named parameters. 
using System;

public class OptionalParameterDemo
{
    // Method with an optional integer parameter
    public static void PrintStringMultipleTimes(string message, int times = 5)
    {
        for (int i = 0; i < times; i++)
        {
            Console.WriteLine(message);
        }
    }

    // Method to demonstrate calling with named parameters
    public static void ShowOptionalParameterExample()
    {
        Console.WriteLine("Using default 'times' value (5):");
        PrintStringMultipleTimes("Hello!");

        Console.WriteLine("\nSpecifying 'times' explicitly:");
        PrintStringMultipleTimes("Hello!", 3);

        Console.WriteLine("\nUsing named parameter:");
        PrintStringMultipleTimes(message: "Hi there!", times: 4);

        Console.WriteLine("\nUsing named parameter with default value:");
        PrintStringMultipleTimes(message: "Welcome!");
    }
}
