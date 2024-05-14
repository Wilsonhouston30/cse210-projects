using System;
using System.ComponentModel;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        // Visible menu for the user which converts input into an int
        var usermenu = "";
        while (usermenu != "5")
        {
            Console.WriteLine("1.Enter Entry");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            usermenu = Console.ReadLine();
            

            if (usermenu == "1")
            {
                Journal entry1 = new Journal();
                entry1.Promt();
                string userEntry = Console.ReadLine();
                Console.WriteLine();
            }
            if (usermenu == "2")
            {
                Console.WriteLine("Display");
                Console.WriteLine();
            }
            if (usermenu == "3")
            {
                Console.WriteLine("Load");
                Console.WriteLine();
            }
            if (usermenu == "4")
            {
                Console.WriteLine("Save");
                Console.WriteLine();
            }
            


        }    
            
            
    }
}