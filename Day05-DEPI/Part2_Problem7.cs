// Program to Reverse Words in a Sentence 
// Given a sentence with space-separated words, write a program to reverse the order of the words. 
// Example: 
// Input: English is great 
// Output: great is English 
// Note: 
// Use the Split function. 
// The output should be a single Console.WriteLine statement.
using System;

public class ReverseWordsDemo
{
    public static void ShowReverseWords()
    {
        // Ask user for input
        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine();

        if (!string.IsNullOrEmpty(sentence))
        {
            // Split the sentence into words
            string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Reverse the array of words
            Array.Reverse(words);

            
            Console.WriteLine(string.Join(" ", words));
        }
        else
        {
            Console.WriteLine("No input provided.");
        }
    }
}
