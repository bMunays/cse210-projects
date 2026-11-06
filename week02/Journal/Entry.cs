public class Entry()
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        // from week02: Working with dates in C#
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}