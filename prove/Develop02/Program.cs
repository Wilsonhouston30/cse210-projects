using System;
using System.ComponentModel;
using System.Reflection;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        // Visible menu for the user which converts input into an int
        var userMenu = "";
        Journal person_1 = new Journal ();

        while (userMenu != "5")
        {
            Console.WriteLine("1.Add Entry:");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine();
            userMenu = Console.ReadLine();
            

            if (userMenu == "1")
            /// Displays prompt and saves userEntry 
            {
                person_1.newEntry();
            }
            else if (userMenu == "2")
            // Displays current entries and prompts
            {
                person_1.DisplayEntries();
            }
            else if (userMenu == "3")
            // Ask user whats the name of the file of journal then displays entries 
            {
                person_1.LoadEntries();
            }
            else if (userMenu == "4")
            // ask user of name of file, saves the file under the user input
            {
                person_1.SaveEntries();
            }
            


        }    
            
            
    }
}