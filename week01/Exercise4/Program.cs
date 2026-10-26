using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        List<string> words = new List<string>();

        // add items to the list
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");

        // get the size of the list
        Console.WriteLine(words.Count);

        // iterating through a list
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // access items by their indices
        for (int i = 0; i < words.Count; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}