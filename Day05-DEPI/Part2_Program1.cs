// Program to Print Numbers in a Range 
// Write a program that allows the user to insert a positive integer, then print all numbers from 1 to 
// that number. 
using System;

public class PrintNumbersDemo
{
    public static void ShowNumbersInRange()
    {
        int number;

        // Ask user for a positive integer
        Console.Write("Enter a positive integer: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        // Print numbers from 1 to the entered number, separated by commas
        for (int i = 1; i <= number; i++)
        {
            if (i < number)
                Console.Write(i + ", ");
            else
                Console.WriteLine(i); // No comma after the last number
        }
    }
}

