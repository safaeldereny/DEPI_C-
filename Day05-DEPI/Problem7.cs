// Problem: Demonstrate the use of nullable reference types by: 
// o Declaring a nullable string. 
// o Assigning it a value conditionally based on user input. 
// o Using the null-forgiveness operator (!) to suppress warnings. 
using System;

public class NullableReferenceDemo
{
    public static void ShowNullableReferenceExample()
    {
        // Declare a nullable string
        string? name = null;

        // Assign it a value conditionally based on user input
        Console.Write("Enter your name (or leave empty): ");
        string? input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
        {
            name = input;
        }

        Console.WriteLine("Hello, " + name!);
    }
}
