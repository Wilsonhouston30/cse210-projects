public class PromtGenerator

{
    public static string[] _promts = {
        "What is one fear or obstacle that is holding me back, and what can I do to overcome it?",
        "What did I learn today? How can I apply this in the future?",
        "Who in your life from this past week you are you gratefull for?",
        "What is one thing that I cant live without?",

    };
    public List<string> _promt = new List<string>(_promts);

    public void GetRandomPromt()
    {
        Random randomgen = new Random();
        int randomPromt = randomgen.Next(1, 5);
        string journalPromt = _promt[randomPromt];

    }

    public string Get()
    {
        Random randomgen = new Random();
        int randomPromt = randomgen.Next(1, 5);
        string journalPromt = _promt[randomPromt];

        return journalPromt;

    }

}