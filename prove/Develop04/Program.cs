using System;

class Program
{
    static void Main(string[] args)
    {

        static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Please select one: ");
            string [] _menu = {"Listening", "Refelection", "Breathing", "Quit"};
            for  (int i = 0; i <_menu.Length; i++ )
            {
                Console.WriteLine($"{i +1}: {_menu[i]} Activity");
            }


        }

        loading loading1 = new loading();

        int selection = 0;
        while (selection != 4)
        {
            Menu();
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                ListeningActivity listeningActivity1 = new ListeningActivity(0);
                loading1.LoadingAnimation();
                listeningActivity1.StartListeningActivity();
                listeningActivity1.DisplayEnding();
            }
            else if (selection == 2)
            {
                ReflectionActivity reflectionActivity1 = new ReflectionActivity(0);
                loading1.LoadingAnimation();
                reflectionActivity1.StartReflectingActivity();
                reflectionActivity1.DisplayEnding();

            }
            else if (selection == 3)
            {
                BreathingActivity breathing1 = new BreathingActivity(0);
                loading1.LoadingAnimation();
                breathing1.StartBreathingActivity();
                breathing1.DisplayEnding();

            }
            else if (selection == 4)
            {
                Console.WriteLine("Quit");
            }
            else
            {
                Console.WriteLine("Invalid number");
                Console.WriteLine("Please enter number between 1-4");
            }
        }
        Console.WriteLine("Goodbye");
        
    }
}