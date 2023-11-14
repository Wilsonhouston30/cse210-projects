using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program");
        }
        DisplayMessage();

        static string PromtUserName()
        {
            Console.Write($"What is your name: ");
            string name = Console.ReadLine();
            return name;
        }
        string userName = PromtUserName();

        static int UserNumber()
        {
            Console.Write("What is your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        int usernum = UserNumber();

        static int SquareNumber(int number)
        {
            int sqroot = number * number;
            return sqroot;
        }
        int squaredNumber = SquareNumber(usernum);

    }
}