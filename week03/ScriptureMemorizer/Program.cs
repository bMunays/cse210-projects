// To exceed the core requirements,
// 1. I added List<Scripture> in Program.cs so that the program randomly 
//    selects one scripture to present to the user each run.
// 2. The HideRandomWords method in the Scripture class now filters out words 
//    that are already hidden so that only visible words are randomly selected.


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        /* Initial base code for the core requirements
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);
        */


        // code for the exceed requirements
        List<Scripture> scriptureLibrary = new List<Scripture>();

        // Add scriptures to the library
        scriptureLibrary.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and he shall direct thy paths."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth on him should not perish, but have everlasting life."
        ));

        scriptureLibrary.Add(new Scripture(
            new Reference("Psalm", 23, 1, 2),
            "The Lord is my shepherd; I shall not want. He maketh me to lie down in green pastures: he leadeth me beside the still waters."
        ));


        // Randomly select one scripture from the library
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture selectedScripture = scriptureLibrary[randomIndex];


        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText()); // Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (selectedScripture.IsCompletelyHidden()) // scripture
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
            selectedScripture.HideRandomWords(3); // scripture
        }
    }
}