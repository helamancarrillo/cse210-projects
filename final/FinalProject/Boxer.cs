

public class Boxer : Athlete
{
    //member variables
     
    private float _mass; //kg
    private float _acceleration; //ms

    //constructor 

    public Boxer(string name, int age, float mass, float acceleration) : base(name, age) 
    {
        _mass = mass; 

        _acceleration = acceleration; 
    }

    // method 

    public override string Record()
    {
        float force = _mass * _acceleration; 

        double speedRounded = force;
        int decimalPlaces = 2;

        double roundedForce = Math.Round(speedRounded, decimalPlaces);

        string save = $"At {_age} years old, {_name} has achieved a personal force boxing record of {roundedForce} N. ";

        return save; 
    }

    


}