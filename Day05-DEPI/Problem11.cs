// Problem: Write a program that: 
// o Asks the user to enter a day of the week. 
// o Uses a switch expression to map the day to its corresponding number (e.g., "Monday" -> 1). 
using System;

public class DayOfWeekDemo
{
    public static void ShowDayNumberExample()
    {
        //  Ask the user to enter a day of the week
        Console.Write("Enter a day of the week: ");
        string? day = Console.ReadLine()?.Trim();

        // Use a switch expression to map day to its number
        int dayNumber = day?.ToLower() switch
        {
            "monday" => 1,
            "tuesday" => 2,
            "wednesday" => 3,
            "thursday" => 4,
            "friday" => 5,
            "saturday" => 6,
            "sunday" => 7,
            _ => 0 // default case for invalid input
        };

        // Print the result
        if (dayNumber != 0)
            Console.WriteLine("{day} corresponds to day number {dayNumber}.");
        else
            Console.WriteLine("Invalid day entered.");
    }
}

