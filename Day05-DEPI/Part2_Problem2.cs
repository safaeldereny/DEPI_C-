// Program to Display Multiplication Table 
// Write a program that allows the user to insert an integer, then print the multiplication table for 
// that number up to 12 times. 
using System;

public class MultiplicationTableDemo
{
    public static void ShowMultiplicationTable()
    {
        int number;

        // Ask user for an integer
        Console.Write("Enter an integer: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }

        // Print multiplication table up to 12 times
        for (int i = 1; i <= 12; i++)
        {
            if (i < 12)
                Console.Write(number * i + ", ");
            else
                Console.WriteLine(number * i); // No comma after the last number
        }
    }
}
