using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        
        // print empty line
        Console.WriteLine("");

        // get the student's mark
        Console.Write("Enter your mark: ");
        int mark = int.Parse(Console.ReadLine());

        char letter;

        // get sign for the grade
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
        else
        {
            sign = ' ';
        }
        
        
        // decide grade
        if (mark >= 90)
        {
            letter = 'A';
        }
        else if (mark >= 80)
        {
            letter = 'B';
        }
        else if (mark >= 70)
        {
            letter = 'C';
        }
        else if (mark >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }


        // assign sign next to grade where applicable and print
        if (mark >= 97 || mark < 60)
        {
            Console.WriteLine($"{letter}");
        }
        else
        {
            Console.WriteLine($"{letter}{sign}");
        }


        // congratulate if they passed the course (mark >= 70)
        if (mark >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else // encourage them for next time.
        {
            Console.WriteLine("You did not do well in the test. Try again next time.");
        }
    }
}