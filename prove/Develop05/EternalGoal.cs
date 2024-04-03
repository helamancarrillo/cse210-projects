
 public class EternalGoal : Goal
 {
    // member variable are not needed 

    // constructor 

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // methods => functions 

    public override string RecordEvent()
    {
        

        //Console.WriteLine(_points); 
        return $"[] {_shortName}: {_description}";
    }

    public override bool IsComplete()
    {
        return false; 
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, {_points}, {false}";
    }

    public override int Pointsearned()
    {
        return _points;
    }






 }