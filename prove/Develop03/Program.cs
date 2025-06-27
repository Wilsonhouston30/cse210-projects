
using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string userinput = " ";
        Scripture scripture = new Scripture("D&C",63,64,"Remember that that which commeth from above is sacred, and must be spoken with care, and by constraint of the spirit; This there is no condemation, and ye receive the sprit through prayer; wherefore without this there remainith condemation");
        
        Console.ReadLine();
        Console.Clear();

        bool completed = false;

        while (!completed && userinput.ToUpper() != "QUIT")
        {

            Console.WriteLine(scripture.GetVerse());

            if (userinput.ToUpper() != "QUIT")
            {
                completed = scripture.HideScripture();
                userinput = Console.ReadLine();
                Console.Clear();
            }

        }
        Console.WriteLine("Done");

        Console.ReadKey();


    }
}
