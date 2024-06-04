using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Person w = new Person();
        w.SetFirstName("Wilson");

        Console.WriteLine(w.GetFirstName());
        

    }
        
}