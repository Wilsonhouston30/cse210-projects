public class Activity
{
    private string _activtyName;
    private string _instruction;

    private int _activtyTimer;

    public Activity (string activtyName, string instruction, int activityTimer)
    {
        _activtyName = activtyName;
        _instruction = instruction;
        _activtyTimer = activityTimer;
    }

    public string GetActivityName()
    {
        return _activtyName;
    }
    public string GetInstruction()
    {
        return _instruction;
    }
    public void SetTimer(int timer)
    {
        _activtyTimer = timer;
    }

    public int RetrieveTimer()
    {
        Console.WriteLine("Enter timer (seconds):");
        int _activtyTimer = int.Parse(Console.ReadLine());
        return _activtyTimer;
    }
    public int GetActivityTimer()
    {
        return _activtyTimer;
    }


    public void DisplayOverview()
    {
        Console.WriteLine($"Welcome to {GetActivityName()}");
        Console.WriteLine($"Follow these instructions : {GetInstruction()}");
    }

    public void DisplayEnding()
    {
        Console.WriteLine($"{GetActivityName()} has ended");
        Console.WriteLine($"Total time {GetActivityTimer()}");
        Console.ReadKey();
        Console.Clear();
    }
    
}