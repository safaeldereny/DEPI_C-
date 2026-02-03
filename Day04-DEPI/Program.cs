using System;

class Program
{
    static void Main()
    {
//          Write a program that: 
// o Initializes a one-dimensional array in three different ways (new int[size], 
// initializer list, and Array syntax sugar). 
// o Assigns values to each element in the array and prints them. 
// o Demonstrates an IndexOutOfRangeException. 

        // Initializing array using: new int[size]
        int[] arr1 = new int[3];
        arr1[0] = 10;
        arr1[1] = 20;
        arr1[2] = 30;

        Console.WriteLine("Array 1:");
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);
        }

        Console.WriteLine("----------------------");

        // Initializing array using initializer list
        int[] arr2 = new int[] { 1, 2, 3, 4 };

        Console.WriteLine("Array 2 (initializer list):");
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.WriteLine(arr2[i]);
        }

        Console.WriteLine("----------------------");

        // Initializing array using array syntax sugar
        int[] arr3 = { 100, 200, 300 };

        Console.WriteLine("Array 3 (array syntax sugar):");
        for (int i = 0; i < arr3.Length; i++)
        {
            Console.WriteLine(arr3[i]);
        }

        Console.WriteLine("----------------------");

        // Demonstrating IndexOutOfRangeException
        Console.WriteLine("Demonstrating IndexOutOfRangeException:");
        Console.WriteLine(arr3[5]); // Invalid index

    

        // Write a program to: 
        // o Create two arrays (arr1 and arr2). 
        // o Perform a shallow copy and demonstrate how modifying one affects the other. 
        // o Perform a deep copy using the Clone method and show that modifications do not 
        // affect the copied array. 
        
        // Original array
        int[] arr1 = { 1, 2, 3 };

        // Shallow Copy
        int[] arr2 = arr1;   // both point to the same array in memory

        Console.WriteLine("Before modification (Shallow Copy):");
        PrintArray(arr1, "arr1");
        PrintArray(arr2, "arr2");

        // Modify arr2
        arr2[0] = 100;

        Console.WriteLine("\nAfter modifying arr2 (Shallow Copy):");
        PrintArray(arr1, "arr1");
        PrintArray(arr2, "arr2");

        Console.WriteLine("\n-----------------------------");

        // Deep Copy using Clone()
        int[] arr3 = (int[])arr1.Clone();

        Console.WriteLine("Before modification (Deep Copy):");
        PrintArray(arr1, "arr1");
        PrintArray(arr3, "arr3");

        // Modify arr3
        arr3[1] = 200;

        Console.WriteLine("\nAfter modifying arr3 (Deep Copy):");
        PrintArray(arr1, "arr1");
        PrintArray(arr3, "arr3");
    }

    static void PrintArray(int[] arr, string name)
    {
        Console.Write(name + ": ");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();



//     Write a program to: 
// o Create a 2D array with student grades (3 students, 3 subjects each). 
// o Take input from the user to fill the array. 
// o Print the grades for each student using nested loops. 

        // Create a 2D array for 3 students and 3 subjects
        int[,] grades = new int[3, 3];

        // Take input from the user
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter grades for Student {i + 1}:");

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Subject {j + 1}: ");
                grades[i, j] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
        }

        //Print the grades using nested loops
        Console.WriteLine("Student Grades:");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Student {i + 1}: ");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(grades[i, j] + " ");
            }

            Console.WriteLine();
        }

//          Write a program that: 
// o Demonstrates at least 5 array methods (Sort, Reverse, IndexOf, Copy, Clear). 
// o Explains the changes before and after applying each method
//  


        int[] arr = { 5, 2, 9, 1, 7 };

        // Original Array
        Console.WriteLine("Original Array:");
        PrintArray(arr);

        // Sort()
        Console.WriteLine("\n1) Array.Sort()");
        Console.WriteLine("Before Sort:");
        PrintArray(arr);

        Array.Sort(arr);

        Console.WriteLine("After Sort:");
        PrintArray(arr);

        // Reverse()
        Console.WriteLine("\n2) Array.Reverse()");
        Console.WriteLine("Before Reverse:");
        PrintArray(arr);

        Array.Reverse(arr);

        Console.WriteLine("After Reverse:");
        PrintArray(arr);

        // IndexOf()
        Console.WriteLine("\n3) Array.IndexOf()");
        int index = Array.IndexOf(arr, 9);
        Console.WriteLine("Index of element 9 = " + index);

        // Copy()
        Console.WriteLine("\n4) Array.Copy()");
        int[] copyArr = new int[arr.Length];

        Console.WriteLine("Before Copy:");
        PrintArray(copyArr);

        Array.Copy(arr, copyArr, arr.Length);

        Console.WriteLine("After Copy:");
        PrintArray(copyArr);

        // Clear()
        Console.WriteLine("\n5) Array.Clear()");
        Console.WriteLine("Before Clear:");
        PrintArray(arr);

        Array.Clear(arr, 0, arr.Length);

        Console.WriteLine("After Clear:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

    
//     Create a program that: 
// o Uses a for loop to print all elements of a 1D array. 
// o Uses a foreach loop to print all elements of the same array. 
// o Uses a while loop to print all elements in reverse order. 

        int[] arr = { 10, 20, 30, 40, 50 };

        // Using for loop
        Console.WriteLine("Using for loop:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine("-------------------");

        // Using foreach loop
        Console.WriteLine("Using foreach loop:");
        foreach (int item in arr)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("-------------------");

        // Using while loop (reverse order)
        Console.WriteLine("Using while loop (reverse order):");
        int index = arr.Length - 1;
        while (index >= 0)
        {
            Console.WriteLine(arr[index]);
            index--;
        }
        

//      Write a program that: 
// o Repeatedly asks the user for a positive odd number. 
// o Uses defensive coding to validate input using int.TryParse and a do-while 
// loop.    

        int number;

        do
        {
            Console.Write("Enter a positive odd number: ");
            string input = Console.ReadLine();

            // Defensive coding: validate input
            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input! Please enter an integer.\n");
                number = -1; // force loop to continue
                continue;
            }

            if (number <= 0)
            {
                Console.WriteLine("Number must be positive!\n");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("Number must be odd!\n");
            }

        } while (number <= 0 || number % 2 == 0);

        Console.WriteLine($"\nYou entered a valid positive odd number: {number}");


//     Write a program to: 
// o Create a 2D array with fixed values. 
// o Print the array elements in a matrix format (rows and columns)
     
        // Create a 2D array with fixed values
        int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Print the array in matrix format
        Console.WriteLine("2D Array in Matrix Format:");
        for (int i = 0; i < matrix.GetLength(0); i++) // rows
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // columns
            {
                Console.Write(matrix[i, j] + "\t"); // tab for spacing
            }
            Console.WriteLine(); // new line after each row
        }

//     Write a program that: 
// o Asks the user to enter a month number. 
// o Uses an if-else statement to determine the month name. 
// o Uses a switch statement to perform the same task. 
 
        Console.Write("Enter a month number (1-12): ");
        string input = Console.ReadLine();
        int month;

        // Validate input
        if (!int.TryParse(input, out month) || month < 1 || month > 12)
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 12.");
            return;
        }

        // Using if-else
        Console.WriteLine("\nUsing if-else:");
        if (month == 1) Console.WriteLine("January");
        else if (month == 2) Console.WriteLine("February");
        else if (month == 3) Console.WriteLine("March");
        else if (month == 4) Console.WriteLine("April");
        else if (month == 5) Console.WriteLine("May");
        else if (month == 6) Console.WriteLine("June");
        else if (month == 7) Console.WriteLine("July");
        else if (month == 8) Console.WriteLine("August");
        else if (month == 9) Console.WriteLine("September");
        else if (month == 10) Console.WriteLine("October");
        else if (month == 11) Console.WriteLine("November");
        else if (month == 12) Console.WriteLine("December");

        // Using switch
        Console.WriteLine("\nUsing switch:");
        switch (month)
        {
            case 1: Console.WriteLine("January"); break;
            case 2: Console.WriteLine("February"); break;
            case 3: Console.WriteLine("March"); break;
            case 4: Console.WriteLine("April"); break;
            case 5: Console.WriteLine("May"); break;
            case 6: Console.WriteLine("June"); break;
            case 7: Console.WriteLine("July"); break;
            case 8: Console.WriteLine("August"); break;
            case 9: Console.WriteLine("September"); break;
            case 10: Console.WriteLine("October"); break;
            case 11: Console.WriteLine("November"); break;
            case 12: Console.WriteLine("December"); break;
            default: Console.WriteLine("Invalid month!"); break;
        }

//     Write a program to: 
// o Sort an array of integers using Array.Sort(). 
// o Search for a specific value using Array.IndexOf() and Array.LastIndexOf().
    
        int[] numbers = { 5, 2, 9, 1, 7, 2, 5 };

        // Print original array
        Console.WriteLine("Original Array:");
        PrintArray(numbers);

        // Sort the array
        Array.Sort(numbers);
        Console.WriteLine("\nArray after Array.Sort():");
        PrintArray(numbers);

        // Ask user for a value to search
        Console.Write("\nEnter a number to search: ");
        int value;
        if (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        // Search using IndexOf
        int firstIndex = Array.IndexOf(numbers, value);
        if (firstIndex != -1)
            Console.WriteLine($"First occurrence of {value} is at index: {firstIndex}");
        else
            Console.WriteLine($"{value} not found in the array.");

        // Search using LastIndexOf
        int lastIndex = Array.LastIndexOf(numbers, value);
        if (lastIndex != -1)
            Console.WriteLine($"Last occurrence of {value} is at index: {lastIndex}");
        else
            Console.WriteLine($"{value} not found in the array.");
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


//     Write a program that: 
// o Creates an array of integers. 
// o Uses a for loop to calculate and print the sum of all elements. 
// o Uses a foreach loop to calculate the same sum. 

        // Create an array of integers
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Calculate sum using for loop
        int sumFor = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sumFor += numbers[i];
        }
        Console.WriteLine("Sum using for loop: " + sumFor);

        // Calculate sum using foreach loop
        int sumForeach = 0;
        foreach (int num in numbers)
        {
            sumForeach += num;
        }
        Console.WriteLine("Sum using foreach loop: " + sumForeach);
        }
    

//     Write a program that takes an integer input from the user (1-7) and prints the 
// corresponding day using the enum. 

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7) for the day of the week: ");
        string input = Console.ReadLine();
        int dayNumber;

        // Validate input
        if (!int.TryParse(input, out dayNumber) || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            return;
        }

        // Convert number to enum (subtract 1 because enum starts from 0)
        DayOfWeek day = (DayOfWeek)(dayNumber - 1);
        Console.WriteLine($"The day is: {day}");
    }
}

// Use Enum.Parse to convert an integer to an enum value. 
enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7) for the day of the week: ");
        string input = Console.ReadLine();
        int dayNumber;

        // Validate input
        if (!int.TryParse(input, out dayNumber) || dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 7.");
            return;
        }

        // Convert number to string representation of enum
        string enumName = ((DayOfWeek)(dayNumber - 1)).ToString();

        // Use Enum.Parse to convert string to enum value
        DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), enumName);

        Console.WriteLine($"The day is: {day}");
    }
}

     
    }







