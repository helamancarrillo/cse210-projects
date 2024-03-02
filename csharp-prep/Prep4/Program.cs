using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int toAddNumber = -1; 

        List<int> words = new List<int>();

         

        while (toAddNumber != 0)
        {

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            toAddNumber = int.Parse(userInput);


            words.Add(toAddNumber);

        

        }

        int sum = words.Sum();

        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / words.Count;

        Console.WriteLine($"The average is: {average}");

        int largest = words.Max();

        Console.WriteLine($"The largest number is: {largest}");






        /*foreach (int word in words)
            {
                Console.WriteLine(word);
            }  */

         


        














    }




   


}