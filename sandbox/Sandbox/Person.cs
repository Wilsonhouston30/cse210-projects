using System;
class Person
{
    public string givenName;
    public string familyName;

    // In C# we use the same name as the class when calling a constructor, Constructors never return anything
    public Person(string givenName, string familyName) {
        this.givenName = givenName;
        this.familyName = familyName;

    }
    public void EasternStyleName(){
        Console.WriteLine($"{this.familyName}, {this.givenName} ");

    }
    public void WesternStyleName(){
        Console.WriteLine($"{this.givenName}, {this.familyName} ");

    }
}