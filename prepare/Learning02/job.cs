public class Job
{
    public string jobTitle;
    public string companyName;
    public int startYear;
    public int endYear;

    public void Display()
    {
        Console.WriteLine($"{jobTitle} ({companyName}) {startYear} - {endYear}");
    }


}