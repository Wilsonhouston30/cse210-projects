public class BreathingActivity :Activity
{
    public BreathingActivity(int timer) : base ("Breathing Activity","Follow along the displayed promts as you focus on your breathing try to set your mind into a sceanary of peace.",timer)
    {

    }

    public void StartBreathingActivity()
    {
        DisplayOverview();
        SetTimer(RetrieveTimer());
        int duration = RetrieveTimer();
        DateTime dateTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < dateTime)
        {
            Console.WriteLine("Breath in....");
            for (int i = 5; i > 0;i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Breath out....");
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
    }

}