using System;
using System.Collections.Frozen;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Car Camero = new Car("Voltswagon", 1950);
        Camero.Info();
        Camero.Driver();
        
    }
        
}