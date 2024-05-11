using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Resume Program");

        Job job1 = new Job();
        job1.jobTitle = "Product Manager";
        job1.companyName = "Sunrun";
        job1.startYear = 1999;
        job1.endYear = 2024;
        job1.Display();
        Job job2 = new Job();
        job2.jobTitle = "Software Engineer";
        job2.companyName = "Nvida";
        job2.startYear = 2023;
        job2.endYear = 2024;
        job2.Display();

        Resume Wilson_Resume = new Resume();
        Wilson_Resume.Name = "Wilson";
        Wilson_Resume.jobs.Add(job1);
        Wilson_Resume.jobs.Add(job2);
        
        Console.WriteLine(Wilson_Resume.jobs[0].jobTitle);

        Console.WriteLine("Check check");
        Wilson_Resume.Display();



    }
}