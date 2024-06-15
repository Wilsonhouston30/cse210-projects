using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

public class Person
{
    private string first_name;
    private string last_name;
    private int age;

    public string First_Name
    {
        get {return first_name;}
        set {first_name = value;}
    }

    public string Last_Name 
    {
        get {return last_name;}
        set {last_name = value;}
    }

    public int Age
    {
        get {return age;}
        set {
            if (value >= 1 )
            {
                age = value;
            }
            else
            {
                throw new ArgumentException ("Have to be older than 0 to create an account");
            }
        }
    }

    public Person (string first_name, string last_name, int age)
    {
        First_Name = first_name;
        Last_Name = last_name;
        Age = age;
    }


    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {first_name}");
        Console.WriteLine($"Last name: {last_name}");
        Console.WriteLine($"age: {age}");
    }
}