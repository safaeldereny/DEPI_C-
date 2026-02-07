// Program to List Even Numbers 
// Write a program that allows the user to insert a number, then print all even numbers between 1 
// and that number. 
using System;

public class EvenNumbersDemo
{
    public static void ShowEvenNumbers()
    {
        int number;

        // Ask user for a positive integer
        Console.Write("Enter a positive integer: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
        {
            Console.Write("Invalid input. Please enter a positive integer: ");
        }

        // Print even numbers from 2 to the entered number
        for (int i = 2; i <= number; i += 2)
        {
            if (i < number && (i + 2) <= number)
                Console.Write(i + ", ");
            else
                Console.WriteLine(i); // Last number without a trailing comma
        }
    }
}
