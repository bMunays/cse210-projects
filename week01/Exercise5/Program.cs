using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        // print empty line
        Console.WriteLine("");

        DisplayWelcome();
        string userName = PrintUserName();
        int favoriteNumber = PromptUserNumber();
        int square = SquareNumber(favoriteNumber);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the programme!");   
    }

    static string PrintUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
    }
}