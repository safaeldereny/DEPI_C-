//  Problem: Create a program to: 
// o Declare a 1D array of size 5. 
// o Try accessing an index out of bounds and handle the IndexOutOfRangeException.
using System;

public class ArrayDemo
{
    public static void ShowArrayExample()
    {
        // Declare a 1D array of size 5
        int[] numbers = { 10, 20, 30, 40, 50 };

        try
        {
            // Access an index out of bounds
            Console.WriteLine("Accessing index 5: " + numbers[5]);
        }
        catch (IndexOutOfRangeException ex)
        {
            // Handle the exception
            Console.WriteLine("Exception caught: " + ex.Message);
        }

        // show valid access
        Console.WriteLine("Accessing index 2: " + numbers[2]);
    }
}
