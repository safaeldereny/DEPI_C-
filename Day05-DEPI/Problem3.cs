//  Problem: Write a program that: 
// o Declares a nullable integer. 
// o Uses the null-coalescing operator (??) to assign a default value if the variable is null. 
// o Demonstrates the difference between using HasValue and Value properties
using System;

class NullableDemo
{
    public void ShowNullableExample()
    {
        //  Declare a nullable integer
        int? nullableNumber = null;

        //  Use the null-coalescing operator (??) to assign a default value if null
        int number = nullableNumber ?? 10;
        Console.WriteLine("Value after null-coalescing: " + number);

        //  Demonstrate HasValue and Value properties
        if (nullableNumber.HasValue)
        {
            Console.WriteLine("nullableNumber has a value: " + nullableNumber.Value);
        }
        else
        {
            Console.WriteLine("nullableNumber is null.");
        }

        // Assign a value to nullableNumber
        nullableNumber = 25;

        // Show difference again
        if (nullableNumber.HasValue)
        {
            Console.WriteLine("Now nullableNumber has a value: " + nullableNumber.Value);
        }
    }
}
