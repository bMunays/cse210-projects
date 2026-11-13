// To exceed core requirements, I modified the HideRandomWords method in the Scripture class 
// so that it only selects from words that are not already hidden. 
// This ensures the program doesn't waste cycles trying to hide words that 
// have already been replaced by underscores.


using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide 3 words at a time
            scripture.HideRandomWords(3);
        }
    }
}