using System;

class Program
{
    static void Main(string[] args)
    {
 
        //instances 
        //Shape first = new Shape("red"); 

        //Console.WriteLine(first.GetColor());
        //Console.WriteLine(first.GetArea()); 

        Square second = new Square("blue", 3); 
        //Console.WriteLine(second.GetColor());
        //Console.WriteLine(second.GetArea());

        Rectangle third = new Rectangle("yellow", 3, 4);
        //Console.WriteLine(third.GetColor());
        //Console.WriteLine(third.GetArea());

        Circle fourth = new Circle("green", 3);
        //Console.WriteLine(fourth.GetColor());
        //Console.WriteLine(fourth.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(second);
        shapes.Add(third);
        shapes.Add(fourth);


        foreach(Shape shap in shapes)
        {
            double area = shap.GetArea();
            string color = shap.GetColor(); 

            Console.WriteLine($"The color is: {color} and the area: {area} "); 


        }



 
    }

    
}