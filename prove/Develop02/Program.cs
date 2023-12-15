using System;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int menu = 0;








        while (menu != 5)
        {
            Console.WriteLine("Please select the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                PromtGenerator promt = new PromtGenerator();
                promt.Get();

            }




        }

    }
}