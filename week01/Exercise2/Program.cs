using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your mark: ");
        int mark = int.Parse(Console.ReadLine());

        char grade;

        // sign
        char sign = ' ';
        int remainder = mark % 10;
        if (remainder >= 7)
        {
            sign = '+';
        }
        
        else if (remainder < 3)
        {
            sign = '-';
        }
        
        
        // grade
        if (mark >= 90)
        {
            grade = 'A';
        }
        else if (mark >= 80)
        {
            grade = 'B';
        }
        else if (mark >= 70)
        {
            grade = 'C';
        }
        else if (mark >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }


        if (mark >= 97 || mark < 60)
        {
            Console.WriteLine($"{grade}");
        }
        else
        {
            Console.WriteLine($"{grade}{sign}");
        }

        if (mark >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else
        {
            Console.WriteLine("Try again next time.");
        }
    }
}