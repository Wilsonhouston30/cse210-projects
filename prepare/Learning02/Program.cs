using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._title = "Software Engineer";
        job1._startYear = 2000;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Adobe";
        job2._title = "Janitor";
        job2._startYear = 1999;
        job2._endYear = 2000;

        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._name = "Wilson Houston";





        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();


    }
}