using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {/**
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
        }**/

        List<int> numbers = new List<int>();

        int response = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        do
        {
            if (response == 0)
            {
                break;
            }
            else
            {
                Console.Write("Enter number: ");
                response = int.Parse(Console.ReadLine());
                numbers.Add(response);
            }
            

        } while (response != 0);
      
        Console.Write("Numbers entered: ");
        Console.WriteLine(string.Join(", ", numbers));


        // get length of numbers list
        int length = numbers.Count;

        int sum = 0;
        int largest = 0;
        // loop through numbers to find total
        for (int i = 0; i < length; i++)
        {
            sum += numbers[i];

            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {sum/length}");
        Console.WriteLine($"The largest number is {largest}.");
    }
}