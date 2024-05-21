using System.Net;
using System.Reflection;

public class Journal
{
    public List<Entry> entries =  new List<Entry>();
    /// declaring and initializing a variable member of the class
    private PromptGenerator promt =  new PromptGenerator();

    public string journalName;
    

    // newEntry method to ask user to enter entry then add to entry list

    public void newEntry()
    {
        Console.Clear();
        // pulls promt from PromtGen Class and displays
        string randomPrompt = promt.Prompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        
        // pulls users answer to entry
        Console.Write("Enter Entry: ");
        string userEntry = Console.ReadLine();

        // pulls current date
        DateTime timeNow = DateTime.Now;
        string time = timeNow.ToShortDateString();
        
        //intiallizing entry 
        Entry entry = new Entry(randomPrompt, userEntry, time);

        entries.Add(entry);
        Console.Clear();

    }

    public void DisplayEntries()
    {
        Console.Clear();
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveEntries()
    {
        Console.WriteLine("Enter Journal Name: ");
        string fileName = Console.ReadLine() + ".txt";

        string content = "";
        foreach ( Entry entry  in entries)
        {
            content += $"Prompt: {entry.prompt}\nEntry: {entry.response}\nDate: {entry.date} ";
        }

        File.WriteAllText(fileName, content);
        Console.WriteLine($"Journal Saveed as {fileName}");
    }

    public void LoadEntries()
    {
        // asking user for name of journal needed then added ".txt" to user input
        Console.WriteLine("Name of Journal:");
        string loadName = Console.ReadLine() + ".txt";

        string loadedFile = File.ReadAllText(loadName);
        Console.Clear();
        Console.WriteLine(loadedFile);
        
        
        

    }

}