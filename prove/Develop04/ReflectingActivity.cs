

public class ReflectingActivity : Activity 
{
    //member variables 

    protected List<string> _prompts; 

    protected List<string> _questions; 

    // constructor 

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;

        _questions = questions; 
    }

    //methods => functions 

    public void Run()
    {

        string title = @"
          _____       __ _           _   _                             _   _       _ _         
         |  __ \     / _| |         | | (_)                  /\       | | (_)     (_) |        
         | |__) |___| |_| | ___  ___| |_ _ _ __   __ _      /  \   ___| |_ ___   ___| |_ _   _ 
         |  _  // _ \  _| |/ _ \/ __| __| | '_ \ / _` |    / /\ \ / __| __| \ \ / / | __| | | |
         | | \ \  __/ | | |  __/ (__| |_| | | | | (_| |   / ____ \ (__| |_| |\ V /| | |_| |_| |
         |_|  \_\___|_| |_|\___|\___|\__|_|_| |_|\__, |  /_/    \_\___|\__|_| \_/ |_|\__|\__, |
                                                  __/ |                                   __/ |
                                                 |___/                                   |___/ 
        ";

        Console.WriteLine(title);


        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine(); 

        Console.WriteLine($"---{DisplayPrompt()}---");
        Console.WriteLine();

        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions as they related to this experience. ");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        Console.WriteLine($">{DisplayQuestions()}");
        Console.WriteLine();

        DisplayEndingMessage();

    }


    public string GetRandomPrompt()
    {

        Random random = new Random();
        int index = random.Next(_prompts.Count);
    
        
        return _prompts[index];

    }

    public string GetRandomQuestions()
    {

        Random random = new Random();
        int index = random.Next(_questions.Count);
    
        
        return _questions[index];

    }

    public string DisplayPrompt()
    {
        return $"{GetRandomPrompt()}";
    }

    public string DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
    
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestions());
            ShowSpinner(5); 

             
        }

        return $""; 
        
    }



}