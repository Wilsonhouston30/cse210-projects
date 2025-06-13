public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;


    public MathAssignment(string textbookSection, string problems, string name, string topic) : base (name, "Math")
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetInfo()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}