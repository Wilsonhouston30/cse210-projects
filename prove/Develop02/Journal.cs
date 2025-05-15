public class Journal
{
    public List<Entry> _entrys = new List<Entry>();

    public Promt _promt = new Promt();
    public string name;


    public void newEntry()
    {
        Console.WriteLine();


        string promt = _promt.DisplayPromt();

        Console.WriteLine(promt);
        Console.Write("->  ");
        string userResponse = Console.ReadLine();

        DateTime dateTime = DateTime.Now;
        string date = dateTime.ToShortDateString();


        Entry insertingEntry = new Entry(promt, userResponse, date);

        _entrys.Add(insertingEntry);
        Console.Clear();
        Console.WriteLine("Entry Added");
        
    }

    public void Display()
    {
        foreach(Entry entry in _entrys )
        {
            entry.DisplayEntry();
        }
    }
}