
// a code template for the class
public class Job 
{
    // member variables or attributes to obtain data
    public string _jobTitle = "" ;
    public string _company = "";
    public double _startYear ; 

    public double _endYear ; 


    // a special method, called constructor 

    public Job()
    {
    }

    // methods (functions) display data
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }  


}