// Program to Compute Exponentiation 
// Write a program that takes two integers, then prints the result of raising the first number to the 
// power of the second number. 
using System;

public class ExponentiationDemo
{
    public static void ShowExponentiation()
    {
        int baseNumber, exponent;

        // Ask user for the base number
        Console.Write("Enter the base number: ");
        while (!int.TryParse(Console.ReadLine(), out baseNumber))
        {
            Console.Write("Invalid input. Enter an integer: ");
        }

        // Ask user for the exponent
        Console.Write("Enter the exponent: ");
        while (!int.TryParse(Console.ReadLine(), out exponent))
        {
            Console.Write("Invalid input. Enter an integer: ");
        }

        // Compute the result using Math.Pow
        double result = Math.Pow(baseNumber, exponent);

        // Print the result
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
    }
}
