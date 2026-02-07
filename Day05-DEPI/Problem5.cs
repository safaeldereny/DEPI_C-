//  Problem: Write a program that: 
// o Creates a 3x3 array with user-provided values. 
// o Calculates and prints the sum of elements in each row and column.
using System;

class MatrixDemo
{
    public static void SumRowsAndColumns()
    {
        int[,] matrix = new int[3, 3];

    
        Console.WriteLine("Enter 9 numbers for a 3x3 matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                {
                    Console.Write("Invalid input. Enter an integer: ");
                }
            }
        }

        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        //  Sum of each row
        Console.WriteLine("\nSum of each row:");
        for (int i = 0; i < 3; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < 3; j++)
            {
                rowSum += matrix[i, j];
            }
            Console.WriteLine($"Row {i}: {rowSum}");
        }

        // Sum of each column
        Console.WriteLine("\nSum of each column:");
        for (int j = 0; j < 3; j++)
        {
            int colSum = 0;
            for (int i = 0; i < 3; i++)
            {
                colSum += matrix[i, j];
            }
            Console.WriteLine($"Column {j}: {colSum}");
        }
    }
}
