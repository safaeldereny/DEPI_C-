// Write a program to find the longest distance between two identical elements in the array. 
// The distance is the count of cells between the two elements. 
using System;

public class LongestDistanceDemo
{
    public static void ShowLongestDistance()
    {
        // Ask user for the array size
        Console.Write("Enter the size of the array: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Invalid input. Enter a positive integer: ");
        }

        int[] numbers = new int[size];

        // Get array elements from the user
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter element {i}: ");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid input. Enter an integer: ");
            }
        }

        int maxDistance = 0;

        // Loop through array to find the longest distance between matching elements
        for (int i = 0; i < size; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    int distance = j - i - 1; // cells between the two elements
                    if (distance > maxDistance)
                        maxDistance = distance;
                }
            }
        }

        Console.WriteLine("The longest distance between matching elements is: " + maxDistance);
    }
}
