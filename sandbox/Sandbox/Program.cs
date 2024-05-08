using System;
using System.Collections.Frozen;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // How we create an instance of person
        Person fred = new Person("fred", "flinstone");
        Person Tom = new Person("Tom", "Brady");
        Tom.givenName = "Tom";
        Tom.familyName = "Brady";

        fred.EasternStyleName();
        Tom.EasternStyleName();
    }
        
}