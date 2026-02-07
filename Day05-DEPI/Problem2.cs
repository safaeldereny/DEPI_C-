// Problem: Modify the TestDefensiveCode method in demo to: 
// o Accept only positive integers for both X and Y. 
// o Ensure Y is greater than 1. 
using System;

class Demo
{
    public static void TestDefensiveCode(int x, int y)
    {
        if (x <= 0)
        {
            Console.WriteLine("Error: X must be a positive integer.");
            return;
        }

        if (y <= 1)
        {
            Console.WriteLine("Error: Y must be greater than 1.");
            return;
        }

        Console.WriteLine("Valid values: X = " + x + ", Y = " + y);
    }
}

class Problem2
{
    public static void Run()
    {
        Demo.TestDefensiveCode(5, 2);
        Demo.TestDefensiveCode(-3, 1);
    }
}
