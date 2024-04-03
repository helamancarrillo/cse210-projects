
 public class ChecklistGoal : Goal 
 {
    // member variables 

    private int _amountCompleted = 0;

    private int _target;

    private int _bonus; 

    private string _check = "X";  
    private string _notCheck = ""; 

    // constructor

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;

        _bonus = bonus; 

    }

    // methods => functions 

    public override string RecordEvent()
    {
        _amountCompleted++;

        
        if (_amountCompleted >= _target)
        {
            Console.WriteLine("Congratulations you did it!!!");
            
            _points += _bonus;

            //Console.WriteLine($"Score: {_points}");
            
            
            if (_amountCompleted > _target)
            {
                _amountCompleted = _target;
            }
        }

        //Console.WriteLine($"Score: {_points}");

        return $" [{_check}] {_shortName}: {_description} --- Currently completed: {_amountCompleted}/{_target}";

        //return $"{_shortName}: {_description}, {_points}--- Currently completed: {_amountCompleted}/{_target}";
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        {
            return $"{_shortName}"; // [{_check}]  : {_description}, {_points} --- Currently completed: {_amountCompleted}/{_target}";

        }
        else
        {
            return $"{_shortName}";  // [{_notCheck}] : {_description}, {_points}--- Currently completed: {_amountCompleted}/{_target}";
        }
        
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}, {_description}, {_points}, {_amountCompleted}/{_target}";
    }

    public override int Pointsearned()
    {

        if (_amountCompleted == _target)
        {
            return _points += _bonus;
        }
        else 
        {
            return _points; 
        }  

    }

 
}