
public class Square : Shape
{
    // member variables 
    private double _side; 


    // constructor 

    public Square(string color, int side) : base(color)
    {
        _side = side; 
    }


    // method => functions 
    public override double GetArea()
    {
        return _side * _side; 
    }

}