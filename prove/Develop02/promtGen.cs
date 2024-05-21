public class PromptGenerator
{
    public List<string> prompts = new List<string>()
    { 
        "What was the best thing that happened today",
        "What was the most challenging thing I faced today?",
        "What's something I can do to make today amazing?",
        "What could I have done differently today?",
        "How can I bring positivity into my day today?"
    };
    
    // calling a prompt method that pulls a prompt from prompts list 
    public string Prompt()
    {
        Random randomGen = new Random();
        int randomNum = randomGen.Next(0,4);
        string prompt = prompts[randomNum];
        return prompt;
    }

}