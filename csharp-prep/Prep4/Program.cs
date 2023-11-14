using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        Console.WriteLine("Enter a list of number, type 0 when finnished");
        int userInput = -1;
        List<int> numbers = new List<int>();
        float sum = 0;

        while (userInput != 0)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            userInput = int.Parse(number);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        //grabbing the total of number entered
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        //grabbing the average of the numbers entered
        int numberEntered = numbers.Count;
        float average = sum / numberEntered;

        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");






    }
}