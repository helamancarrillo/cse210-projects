

public class SpeedRunner : Athlete
{
    // Attributes inherit from base class
    private int _distanceInMeters;

    private float _timeInMinutes;

    // constructor 
    public SpeedRunner(string name, int age, int distanceInMeters, float timeInMinutes) : base(name, age)
    {
        _distanceInMeters = distanceInMeters; 

        _timeInMinutes = timeInMinutes; 

    }

    // Method 
    public override string Record()
    {
        float speed = _distanceInMeters / _timeInMinutes; 
        double speedrounded = speed;
        int decimalPlaces = 2;

        double roundedSpeed = Math.Round(speedrounded, decimalPlaces);

        string save = $"At {_age} years old, {_name} has achieve a personal speed running record of: {roundedSpeed} mph.";

        
        return save; 
    }


}