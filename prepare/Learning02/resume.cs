public class Resume
{
    public string Name;
    public List<Job> jobs = new List<Job>();
    //initializing the list of Job

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Job:");
        // creating a for loop to iterate through the jobs list 
        foreach (Job i in jobs )
        {
            i.Display();
        }
    }



}