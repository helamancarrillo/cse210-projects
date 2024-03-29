

public class Shape 
{
    // member variables

    private string _color; 

    // getters and setter 

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // constructor 

    public Shape(string color)
    {
        _color = color;

    }

    //method => function

    public virtual double GetArea()
    {
        return -1; 

    }
    


    


}