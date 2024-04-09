

public class SwimmerPace : Athlete
{
    //attributes

    private int _swimmingLaps; 

    private float _timeInMinutes; 

    // constructor

    public SwimmerPace(string name, int age, int swimmingLaps, float timeInMinutes) : base(name, age) 
    {
        _swimmingLaps = swimmingLaps; 

        _timeInMinutes = timeInMinutes; 
    }

    // method 

    public override string Record()
    {
        int distance = _swimmingLaps * 50 / 100; 

        float pace = distance / _timeInMinutes; 

        double speedRounded = pace;
        int decimalPlaces = 2;

        double roundedPace = Math.Round(speedRounded, decimalPlaces);

        string save = $"At {_age} years old, {_name} has achieved a personal swimming pace record of {roundedPace} mpk. ";

        return save; 
    }




}