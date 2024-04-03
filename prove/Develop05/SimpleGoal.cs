

 
 public class SimpleGoal : Goal
 {
    //member variable 

    protected bool _isComplete;

    private string _check = "X";  
    private string _notCheck = ""; 

    // constructor 

    public SimpleGoal(string name, string description, int points, bool iscomplete) : base(name, description, points)
    {
        _isComplete = iscomplete; 
    }

    // methods => functions 

    public override string RecordEvent()
    {

        //if (_isComplete == true)
        //{
            // Mark the goal as complete
        //Console.WriteLine($"Score: {_points}");
        return $"[{_check}] {_shortName}: {_description}";
         
        //}
        //else
        //{    
        //    return $"[{_notCheck}] {_shortName}: {_description}";
        //}

    }

    public override bool IsComplete()
    {
        return _isComplete; 
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}: {_description}, {_points}, {_isComplete}";
    }

    public override int Pointsearned()
    {
        return _points;
    }


}