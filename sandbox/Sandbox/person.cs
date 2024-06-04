public class Person
{
    private string title;
    private string firstName;
    private string lastName;

    public Person()
    {
        title = "";
        firstName = "Anonymous";
        lastName = "Unknown";
    }

    public Person (string firstName, string lastName)
    {
        title = "";
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Person(string title, string firstName, string lastName)
    {
        this.title = title;
        this.firstName = firstName;
        this.lastName = lastName;
    }


    public string GetFirstName()
    {
        return firstName;
    }

    public void SetFirstName(string firstName)
    {
        this.firstName = firstName;
    }
}