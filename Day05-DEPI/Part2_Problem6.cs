// Program to Reverse an Integer Value 
// Write a program that allows the user to enter an integer and then prints the integer with its digits 
// in reverse order. 
using System;

public class ReverseIntegerDemo
{
    public static void ShowReverseInteger()
    {
        int number;

        // Ask user for input
        Console.Write("Enter an integer: ");
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a valid integer: ");
        }

        int originalNumber = number;
        int reversedNumber = 0;

        // Handle negative numbers
        int sign = number < 0 ? -1 : 1;
        number = Math.Abs(number);

        // Reverse the digits
        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number /= 10;
        }

        reversedNumber *= sign; // Restore original sign if negative

        // Print the reversed number
        Console.WriteLine($"Reversed integer of {originalNumber} is {reversedNumber}");
    }
}
