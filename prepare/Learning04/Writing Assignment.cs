
using System.Runtime.InteropServices;

public class WritingAssignment : Assignment
{
    // member variables 
    private string _title; 

    // constructor 

    public WritingAssignment(string studentname, string topic, string title) : base(studentname, topic)
    {
        _title = title;
    }

    //methods => functions 

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";

    }






}