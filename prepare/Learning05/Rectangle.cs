

public class Rectangle : Shape
{
    // member variables 
    private double _length; 

    private double _width; 

    // constructor 

    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length; 

        _width = width; 
    }

    // method => function 

    public override double GetArea()
    {
        return _length * _width; 
    }


}