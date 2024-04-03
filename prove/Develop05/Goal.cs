
public abstract class Goal
{
    //member variables

    protected string _shortName; 

    protected string _description; 

    protected int _points; 

    // constructor 

    public Goal(string name, string description, int points)
    {
        _shortName = name; 

        _description = description; 

        _points = points; 
    }

    // methods => functions 

    public abstract string RecordEvent(); 

    public abstract bool IsComplete(); 

    public virtual string GetDetailsString()
    {
        return $"{_shortName}"; // : {_description}"; 
    }

    public abstract string GetStringRepresentation(); 

    public abstract int Pointsearned(); 

}
