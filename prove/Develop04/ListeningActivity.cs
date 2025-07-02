using System.Net.Security;

public class ListeningActivity : Activity
{
    public ListeningActivity(int timer) : base("Listening Acitvity", "These promt's are one worded answers, answer them as quickly as you can as time expires", timer)
    {

    }

    public List<string> _listeningPromts = new List<string>
    {
        "How many people in your life do you love?",
        "Who's are you calling to bust you out of jail?",
        "What's one item you use more than others?",
        "Favorite food?",
        "Favorite drink?",
        "Go to gas station snack?",
        "Favorite hobby?",
        "One word to describe yourself?",
        "Lunch or Breakfast?",
        "Winter or Summer?",

    };

    public Random random = new Random();

    public string DisplayListeningPromt()
    {
        int randomIndex = random.Next(0,_listeningPromts.Count());
        string promt = _listeningPromts[randomIndex];
        return promt;
    }

    public void StartListeningActivity()
    {
        DisplayOverview();
        SetTimer(RetrieveTimer());

        int userCount = 0;

        int duration = GetActivityTimer();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        var responses = new List<(string input, string promt)>();

        while(DateTime.Now < endTime)
        {
            string promt = DisplayListeningPromt();

            Console.WriteLine($"Promt: {promt}");
            Console.WriteLine("> ");
            string input = Console.ReadLine();
            userCount ++;

            responses.Add((input, promt));
            Console.Clear();

            Console.WriteLine($"Times up!! You answer {userCount} promts");
            foreach(var response in responses)
            {
                Console.WriteLine($"Promt: {response.promt}");
                Console.WriteLine($"Answer: {response.input}");
                Console.WriteLine();
            }

        }
    }
}