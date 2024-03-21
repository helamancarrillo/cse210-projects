

public class MathAssignment : Assignment
{
    //member variables 

    private string _textbookSection; 

    private string _problems; 

    //constructor 

    public MathAssignment(string studentname, string topic,string textsection, string problems) : base(studentname, topic)
    {
        _textbookSection = textsection; 

        _problems = problems;

    }

    // methods => functions 

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }


}