using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");


        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        

        /*Console.Write("Enter the magic number: ");
        string magic = Console.ReadLine();
        int magicNumber = int.Parse(magic);*/

        int guessNumber = -1; 


        while (guessNumber != magicNumber )
        {
            Console.Write("Enter your guess: ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess); 

            string answer = "";


            if (guessNumber < magicNumber)

            {
               //Console.WriteLine("Higher");
                answer = "Higher";
            }
            else if (guessNumber > magicNumber)
            {
                //Console.WriteLine("Lower");
                answer = "Lower";
            }
            else if (guessNumber == magicNumber)
            {
                //Console.WriteLine("You guessed it!");
                answer = "You guessed it!";
            }
    
            Console.WriteLine($"{answer}");
    
             

        }   

        

    
        


       

        


        





















    }
}