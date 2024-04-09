
public class Athlete
{
    //attributes
    protected string _name; 

    protected int _age; 

    //constructor

    public Athlete(string name, int age)
    {
        _name = name; 

        _age = age;  
    }

    // methods => functions 

    public virtual string Record()
    {
        string introduction = $"At {_age} years old, {_name} has achieved a personal"; 
        //Console.WriteLine($"{introduction} speed record of: {speed} mph.");
        return introduction; 
    
    }
}