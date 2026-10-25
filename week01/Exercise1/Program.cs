using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string surname = Console.ReadLine();

        Console.WriteLine($"Your name is {surname}, {name} {surname}.");

        Console.Write("Enter a number: ");
        int number = int. Parse(Console.ReadLine());
        Console.WriteLine($"The number is {number}.");

        int number = 100;
        string numbers = number.ToString();
        Console.WriteLine($"The string was {numbers}.");
    }
}