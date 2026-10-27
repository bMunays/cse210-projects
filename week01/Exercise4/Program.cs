using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        int response = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (response != 0)
        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);   
            }
        };
      
        // print the list of numbers entered
        // Console.Write("Numbers entered: ");
        // Console.WriteLine(string.Join(", ", numbers));


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

        // calculate average
        // Console.WriteLine($"Sum: {sum}, Length: {length}");
        float average = (float)sum / length;

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average:F3}");
        Console.WriteLine($"The largest number is: {largest}.");


        int bestSoFar = -1;
        foreach (int number in numbers)
        {
            // check if this number is larger than the best so far
            if (response > bestSoFar)
            {
                // This is the best number, so save it to that variable
                bestSoFar = response;
            }
        }


        // smallest number
        int smallestSoFar = 99999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestSoFar)
            {
                // We have a new smallest number
                smallestSoFar = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestSoFar}.");

        // sorting the list
        int[] sortedList = numbers.OrderBy(n => n).ToArray();

        Console.WriteLine("The sorted list is: ");
        foreach (int number in sortedList)
        {
            Console.WriteLine(number);
        }
    }
}