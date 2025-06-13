using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Inheritance prepare");

        Assignment a1 = new Assignment("wilson", "Math");
        Console.WriteLine(a1.DisplaySummary());

        MathAssignment m1 = new MathAssignment("7.2", "5-9","Wilson","");
        Console.WriteLine(m1.DisplaySummary() + m1.GetInfo());
    }
}