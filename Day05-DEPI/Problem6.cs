using System;

public class JaggedArrayDemo
{
    public static void ShowJaggedArrayExample()
    {
        // Create a jagged array with 3 rows of varying sizes
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[2]; // First row has 2 elements
        jaggedArray[1] = new int[3]; // Second row has 3 elements
        jaggedArray[2] = new int[4]; // Third row has 4 elements

        // Populate each row with user input
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"Enter {jaggedArray[i].Length} numbers for row {i}:");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
                {
                    Console.Write("Invalid input. Enter an integer: ");
                }
            }
        }

        // Print all values row by row
        Console.WriteLine("\nJagged Array Contents:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + i + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
