// Problem: Write a method SumAndMultiply that: 
// o Accepts two integers and calculates their sum and product using out parameters. 
// o Calls the method and prints the results. 
using System;

public class OutParameterDemo
{
    public static void SumAndMultiply(int a, int b, out int sum, out int product)
    {
        sum = a + b;
        product = a * b;
    }

    public static void ShowSumAndMultiplyExample()
    {
        int x = 5;
        int y = 3;

        // Declare variables to hold the results
        int sum, product;

        // Call the method
        SumAndMultiply(x, y, out sum, out product);

        Console.WriteLine($"Numbers: {x}, {y}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Product: {product}");
    }
}
