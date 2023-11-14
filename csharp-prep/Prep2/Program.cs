using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is grade percentage?  ");
        string grade = Console.ReadLine();
        int letter = int.Parse(grade);


        if (letter >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (letter >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (letter >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (letter >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else if (letter < 60)
        {
            Console.WriteLine("Grade: F");
        }

        if (letter >= 70)
        {
            Console.Write("You're passing the class. Keep up the great work.");
        }

        else
        {
            Console.Write("You're failing the class. To pass the class you will need 70% or more.");
        }
    }
}