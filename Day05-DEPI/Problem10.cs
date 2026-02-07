// Problem: Write a program that: 
// o Declares a nullable integer array. 
// o Uses the null propagation operator (?.) to safely access its properties.
using System;

public class NullableArrayDemo
{
    public static void ShowNullableArrayExample()
    {
        // Declare a nullable integer array
        int[]? numbers = null; // The array itself can be null

        // Safely access its Length using null propagation (?.)
        Console.WriteLine("Length of numbers array: " + numbers?.Length);

        // Assign an actual array
        numbers = new int[] { 10, 20, 30 };

        // Access Length safely again
        Console.WriteLine("Length of numbers array after initialization: " + numbers?.Length);

        // Use null propagation when accessing elements
        for (int i = 0; i < (numbers?.Length ?? 0); i++)
        {
            Console.WriteLine($"Element [{i}]: {numbers?[i]}");
        }
    }
}
