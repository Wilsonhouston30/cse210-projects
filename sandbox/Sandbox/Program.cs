using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        
        string script = "Sample scripture, use the scripture";
        string [] words = script.Split(" ");

        int wordsLength = words.Length;

        Random randomGen = new Random();
        int randomNum = randomGen.Next(wordsLength);

        
        Console.WriteLine(words[randomNum]);
    }
        
}