public class Journal
{
    List<Entry> entries =  new List<Entry>();
    List<string> promts = new List<string>()
    { 
        "What are some areas of my life where I tend to have a fixed mindset?",
        "What is something silly that always makes me laugh?",
        "What is one quote or saying that inspires me, and how can I apply its wisdom to my life?",
        "What are three things I love about myself?",
        "What are some activities or hobbies that help me relax and de-stress?"
    };

    public void Promt()
    {
        Random randomGen = new Random();
        int randomNum = randomGen.Next(0,4);
        Console.WriteLine(promts[randomNum]);
    }
    


}