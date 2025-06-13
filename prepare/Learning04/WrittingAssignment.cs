public class WrittingAssignment : Assignment
{
    private string _titleOfAssignment;


    public WrittingAssignment(string titleOfAssignemt, string name, string topic) : base(name, "Writting")
    {
        _titleOfAssignment = titleOfAssignemt;
    }

    
}