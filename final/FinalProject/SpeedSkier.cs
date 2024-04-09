
public class SpeedSkier : Athlete
{
    // Attributes inherit from base class

    private int _distanceInMeters;

    private float _timeInMinutes;

    // constructor 
    public SpeedSkier(string name, int age, int distanceInMeters, float timeInMinutes) : base(name, age)
    {
        _distanceInMeters = distanceInMeters; 

        _timeInMinutes = timeInMinutes;

    }

    // Method  
    public override string Record()
    {
        float speed = _distanceInMeters / _timeInMinutes; 

        double speedRounded = speed;
        int decimalPlaces = 2;

        double roundedSpeed = Math.Round(speedRounded, decimalPlaces);

        string save = $"At {_age} years old, {_name} has achieved a personal speed skiing record of: {roundedSpeed} mph.";

        return save;
    
    }
}