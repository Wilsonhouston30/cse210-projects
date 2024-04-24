using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade in class? ");
        string gradeP = Console.ReadLine();
        int percent = Convert.ToInt32(gradeP);

        string letter = "";


        if(percent >= 90 )
        {
            letter = "A";
        }
                else if(percent >= 80 )
        {
            letter = "B";
        }
                else if(percent >= 70 )
        {
            letter = "C";
        }
                else if(percent >= 60 )
        {
            letter = "D";
        }
                else if(percent < 60 )
        {
            letter = "F";
        }


        Console.WriteLine($"You have a {letter}");




    }
}