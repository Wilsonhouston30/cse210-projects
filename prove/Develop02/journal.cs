public class Journal
{
    public List<Entry> entries =  new List<Entry>();
    

    public List<string> promts = new List<string>()
    { 
        "What are some areas of my life where I tend to have a fixed mindset?",
        "What is something silly that always makes me laugh?",
        "What is one quote or saying that inspires me, and how can I apply its wisdom to my life?",
        "What are three things I love about myself?",
        "What are some activities or hobbies that help me relax and de-stress?"
    };

    public string e;
    
    // calling a promt method that pulls a promt from promts list 
    public void Promt()
    {
        Random randomGen = new Random();
        int randomNum = randomGen.Next(0,4);
        Console.WriteLine(promts[randomNum]);
    }
    // newEntry method to ask user to enter entry then add to entry list
    public void newEntry()
    {
        Console.Write("Enter Entry: ");
        string userEntry = Console.ReadLine();

    }
    
    


}