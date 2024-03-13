using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");


        Fraction trying = new Fraction();
        Console.WriteLine(trying.GetFractionString());
        Console.WriteLine(trying.GetDecimalValue());


        Fraction trying2 = new Fraction(5);
        Console.WriteLine(trying2.GetFractionString());
        Console.WriteLine(trying2.GetDecimalValue());


        Fraction trying3 = new Fraction(3,4);
        Console.WriteLine(trying3.GetFractionString());
        Console.WriteLine(trying3.GetDecimalValue());

        Fraction trying4 = new Fraction(1,3);
        Console.WriteLine(trying4.GetFractionString());
        Console.WriteLine(trying4.GetDecimalValue());


        //getters.SetTop(3);
        //getters.SetBottom(4);  

        //Console.WriteLine(getters.GetTop());
        //Console.WriteLine(getters.GetBottom());


        //Console.WriteLine(getters.GetFractionString());
        //Console.WriteLine(getters.GetDecimalValue());



        

    }
}