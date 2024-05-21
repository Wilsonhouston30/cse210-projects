public class Entry
{
    public string prompt;
    public string response;
    public string date;


    public Entry (string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;

    }

    //creating a display behavior to display prompt, response, and date
    public void DisplayEntry()
    {
        Console.WriteLine($"{prompt}");
        Console.WriteLine($"{date} - {response}");
        Console.WriteLine();
    }





}