public class ReflectionActivity : Activity
{
    public ReflectionActivity(int timer): base("Reflection Activity", "Prompts will be displayed answer to the first thought you have, hit enter once you've answer the prompt to move on to the next. Promts will continue till the last promt has been answer when the timer expires", timer)
    {

    }


    public List <string> _reflectionPromts = new List<string>
    {
    "Would your younger self be proud of you?", 
    "What are your biggest strengths? How can you use them to achieve your goals?",
    "What is one area of your life that could use more organization? How can you improve it?",
    "What did you do last week, and what do you want to do this weekend",
    "Who do you spend the most time with at the moment? What's your favorite thing about him/her",
    "What happened recently that made you smile?", "If you had to choose to eat lunch with, who would it be?",
    "What are you grateful for and why?",
    "Describe a recent challenge that you overcame and how you did it.",
    "Whats is the most important thing you learned personally?",
    "what do you have now that you dreamed of having years ago?",
    "When someone gives you a compliment, do you say 'thank you' or refuse it? Why?",
    "What a vivid memory that you had from your childhood?",
    "Write out one sentence that describes you ",
    "What's a meal that you would like to try this instance, and why?",
    "What are you doing now that you wish to improve on?",
    "Who was was your most talked to person this time last year and who is it now?"};     

    public Random random = new Random();

    public string DisplayPromt()
    {
        int randomIndex = random.Next(0,_reflectionPromts.Count());
        string promts = _reflectionPromts[randomIndex];
        return promts;
    }

    public void StartReflectingActivity()
    {
        DisplayOverview();
        SetTimer(RetrieveTimer());

        int userCount = 0;

        int duration = GetActivityTimer();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        var responses = new List<(string input, string promt)>();

        while (DateTime.Now < endTime)
        {
            string promt = DisplayPromt();

            Console.WriteLine($"Promt: {promt}");
            Console.Write("> ");
            string input = Console.ReadLine();
            userCount ++;


            responses.Add((input,promt));
            Console.Clear();

            Console.WriteLine($"Times up!! You answered {userCount} promts");
            foreach(var response in responses)
            {
                Console.WriteLine($"Promt: {response.promt}");
                Console.WriteLine($"Entry: {response.input}");
                Console.WriteLine();
            }

        } 
    }

}