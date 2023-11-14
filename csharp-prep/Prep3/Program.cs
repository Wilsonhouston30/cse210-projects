using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        // using the random class and instance
        Random randomGen = new Random();
        int randomNumber = randomGen.Next(1, 100);
        // declaring the variables userNumber and attempts
        int userNumber = 0;
        int attempts = 0;

        //Console.WriteLine($"The magic number is {randomNumber}");

        while (userNumber != randomNumber)
        {
            Console.Write("Choose a number between 1-100: ");
            string number = Console.ReadLine();
            userNumber = int.Parse(number);
            attempts++;
            if (userNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You Guessed it");
        Console.WriteLine($"Attempts made: {attempts}");



    }
}