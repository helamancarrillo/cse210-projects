

public class Assignment
{
    //member variables 

    protected string _studentName; 

    private string _topic; 

    // constructor 

    public Assignment(string studentname, string topic)
    {
        _studentName = studentname;

        _topic = topic;

    }

    // methods => functions 

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}"; 
        
    }

}