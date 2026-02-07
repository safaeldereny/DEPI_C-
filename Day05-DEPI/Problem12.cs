// Problem: Write a method SumArray that: 
// o Accepts a variable number of integers using the params keyword. 
// o Returns the sum of the provided integers. 
// o Demonstrates calling the method with both an array and individual values. 
using System;

public class ParamsDemo
{
    // Define a method that accepts a variable number of integers
    public static int SumArray(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    // Method to demonstrate calling SumArray
    public static void ShowParamsExample()
    {
        // Calling with individual values
        int sum1 = SumArray(1, 2, 3, 4, 5);
        Console.WriteLine("Sum of individual values: " + sum1);

        // Calling with an array
        int[] nums = { 10, 20, 30 };
        int sum2 = SumArray(nums);
        Console.WriteLine("Sum of array: " + sum2);
    }
}
