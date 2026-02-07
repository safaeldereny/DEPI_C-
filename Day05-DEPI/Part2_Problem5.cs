// Program to Reverse a Text String 
// Write a program that allows the user to enter a string and then prints the string in reverse order.
using System;

public class ReverseStringDemo
{
    public static void ShowReverseString()
    {
        // Ask user for input
        Console.Write("Enter a string: ");
        string? input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input))
        {
            // Convert to char array, reverse, and create a new string
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            // Print the reversed string
            Console.WriteLine("Reversed string: " + reversed);
        }
        else
        {
            Console.WriteLine("No input provided.");
        }
    }
}
