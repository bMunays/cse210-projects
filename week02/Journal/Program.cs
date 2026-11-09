// To exceed the core requirements, 
// I added the ability to capture and save additional information in the journal entry. 
// To be specific, I added a "mood" tracker that prompts the user for their current mood when writing a new entry, 
// stores it in the Entry object, and properly saves and loads this extra data context to and from the text file. 

using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        Console.WriteLine("Welcome to the Journal Programme");

        while (running)
        {
            // display menu
            Console.WriteLine("Please, select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // write a new entry
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();

                    Console.Write("What is your current mood? ");
                    string mood = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._mood = mood; // save mood
                    journal.AddEntry(newEntry);
                    break;

                case "2": // display the Journal
                    journal.DisplayAll();
                    break;

                case "3": // load journal from text file
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4": // save to Journal
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.Write("Invalid option. Please, enter a number from 1 to 5");
                    break;
            }
        }
    }
}