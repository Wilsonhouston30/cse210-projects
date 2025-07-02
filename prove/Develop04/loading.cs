public class loading
{
    public void LoadingAnimation()
    {
        string [] animation = ["[          ] 0%","[-         ] 10%","[--        ] 20%","[---       ] 30%","[----      ] 40%","[-----     ] 50%","[------    ] 60%","[-------   ] 70%","[--------  ] 80%","[--------- ] 99%","[----------] 99.99%"];
        foreach(string animations in animation)
        {
            Console.Clear();
            Console.WriteLine($"{animations} ... loading");
            Thread.Sleep(1000);
        }
        Console.Clear();
        Console.WriteLine("Loading Complete");

    }
}