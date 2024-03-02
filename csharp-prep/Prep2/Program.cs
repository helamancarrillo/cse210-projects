using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int userGrade = int.Parse(userInput); 

        string letter = "";

        if (userGrade >= 90)
        {
            letter = "A";
            //Console.WriteLine("Letter grade: A");
            
        }
        else if (userGrade >= 80)
        {
            letter = "B";
            //Console.WriteLine("Letter grade: B");
            
        }
         else if (userGrade >= 70)
        {
            letter = "C";
            //Console.WriteLine("Letter grade: C");
            
        }
         else if (userGrade >= 60)
        {
            letter = "D";
            //Console.WriteLine("Letter grade: D");
           
        }
         else if (userGrade < 60)
        {
            letter = "F";
            //Console.WriteLine("Letter grade: F");
            
        }

        Console.WriteLine($"Letter grade: {letter}");
        


        

        


        if (userGrade >= 70)
        {
            Console.Write("Congratulations, you did it!");
        }
        else
        {
            Console.Write("Try next time!");
        }












    }
}