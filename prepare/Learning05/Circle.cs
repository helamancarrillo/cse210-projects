

using System.Net.NetworkInformation;

public class Circle : Shape
{
    // member variables 
    private double _radius; 

    public const double PI = 3.1415926535897931;

    // constructor 

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius; 
    }

    // method => funtion 

    public override double GetArea()
    {
        
        return PI * Math.Pow(_radius, 2); 
    }

}