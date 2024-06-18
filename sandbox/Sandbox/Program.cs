using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        int time = Int32.Parse(Console.ReadLine());
        int round = 0;
        int maxRound = time;

        while (round < maxRound)
        {
            for (int i = 0;i <= 10; i++)
            {
                if ( i == 1 || i == 5 || i == 9)
                {
                    Console.Clear();
                    Console.WriteLine("|");
                    Thread.Sleep(100);
                }
                else if ( i == 2 || i == 6 || i == 10)
                {
                    Console.Clear();
                    Console.WriteLine("\\");
                    Thread.Sleep(100);
                    
                }
                else if ( i == 3 || i == 7)
                {
                    Console.Clear();
                    Console.WriteLine("-");
                    Thread.Sleep(100);
                }
                else if ( i == 4 || i == 8)
                {
                    Console.Clear();
                    Console.Clear();
                    Console.WriteLine("/");
                    Thread.Sleep(100);


                }
            }
            round ++;
        }
    }
}