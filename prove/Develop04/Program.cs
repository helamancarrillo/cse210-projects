// to exceed the requirements I added different text titles to each one of the activities 


using System;

class Program
{
    static void Main(string[] args)
    {
        //intances

        /*Activity first = new Activity("Breating Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 30);

        first.DisplayStartingMessage();
        first.ShowSpinner(5);

        Console.WriteLine();

        first.DisplayEndingMessage();

        //first.ShowCountDown(9);  */ 

        string title = @"
        __  __ _           _  __       _                       _____                                     
       |  \/  (_)         | |/ _|     | |                     |  __ \                                    
       | \  / |_ _ __   __| | |_ _   _| |_ __   ___  ___ ___  | |__) | __ ___   __ _ _ __ __ _ _ __ ___  
       | |\/| | | '_ \ / _` |  _| | | | | '_ \ / _ \/ __/ __| |  ___/ '__/ _ \ / _` | '__/ _` | '_ ` _ \ 
       | |  | | | | | | (_| | | | |_| | | | | |  __/\__ \__ \ | |   | | | (_) | (_| | | | (_| | | | | | |
       |_|  |_|_|_| |_|\__,_|_|  \__,_|_|_| |_|\___||___/___/ |_|   |_|  \___/ \__, |_|  \__,_|_| |_| |_|
                                                                                __/ |                    
                                                                               |___/                     
               
        ";

        Console.WriteLine(title);


        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformBreathingActivity();
                    break;
                case "2":
                    PerformReflectingActivity();
                    break;
                case "3":
                    PerformListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    

        static void PerformBreathingActivity()
        {
            BreathingActivity second = new BreathingActivity("Breating Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing", 10 );

            second.Run();
        }

        static void PerformReflectingActivity()
        {
            List<string> reflectPrompts = new List<string>
            {
                "Think of a time when you stood up for someone else. ",
                "Think of a time when you did something really difficult. ",
                "Think of a time when you helped someone in need. ",
                "Think of a time when you did something truly selfless. "
                  
            };
    
            List<string> reflectQuestions = new List<string>
            {
                "Why was this experience meaningful to you? ",
                "Have you ever done anything like this before? ",
                "How did you get started? ",
                "How did you feel when it was complete? ",
                "What made this time different than other times when you were not as successful? ",
                "What is your favorite thing about this experience? ",
                "What could you learn from this experience that applies to other situations? ",
                "What did you learn about yourself through this experience? ",
                "How can you keep this experience in mind in the future? " 
                  
            };

            ReflectingActivity fourth = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10, reflectPrompts , reflectQuestions );
    
            fourth.Run();
        }

        static void PerformListingActivity()
        {
            List<string> prompts = new List<string>
            {
                "Who are people that you appreciate?  ",
                "What are personal strengths of yours? ",
                "Who are people that you have helped this week? ",
                "When have you felt the Holy Ghost this month? ",
                "Who are some of your personal heroes? "
                
            }; 
    
    
    
            ListingActivity third = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10, 5, prompts);
    
            third.Run();
        }





         
    }
}