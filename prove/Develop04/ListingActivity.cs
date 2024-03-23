
public class ListingActivity : Activity
{
    // member variables 
    private int _count; 

    protected List<string> _prompts = new List<string>();

    // constructor 

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count; 

        _prompts = prompts;
    
    }

    // methods => functions 


    public void Run()
    {

        string title = @"
          _      _     _   _                             _   _       _ _         
         | |    (_)   | | (_)                  /\       | | (_)     (_) |        
         | |     _ ___| |_ _ _ __   __ _      /  \   ___| |_ ___   ___| |_ _   _ 
         | |    | / __| __| | '_ \ / _` |    / /\ \ / __| __| \ \ / / | __| | | |
         | |____| \__ \ |_| | | | | (_| |   / ____ \ (__| |_| |\ V /| | |_| |_| |
         |______|_|___/\__|_|_| |_|\__, |  /_/    \_\___|\__|_| \_/ |_|\__|\__, |
                                    __/ |                                   __/ |
                                   |___/                                   |___/ 
        ";

        Console.WriteLine(title);

        DisplayStartingMessage();


        Console.WriteLine("Lists as many responses you can to the following prompt:");
        Console.WriteLine(); 

        Console.WriteLine($"---{GetRandomPrompt()}---");
        Console.WriteLine();  

        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        GetListFromUser();

        DisplayEndingMessage(); 

    }


    public string GetRandomPrompt()
    {
        //_prompts.Add("Think of a time when you stood up for someone else.");
        //_prompts.Add("Think of a time when you did something really difficult.");
        //_prompts.Add("Think of a time when you helped someone in need.");
        //_prompts.Add("Think of a time when you did something truly selfless."); 

        Random random = new Random();
        int index = random.Next(_prompts.Count);
    
        
        return _prompts[index];

    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
    
        List<string> answers = new List<string>();
    
        
        while (DateTime.Now < endTime)
        {
           
            Console.Write("> ");
            string answer = Console.ReadLine().Trim();
    
            
            answers.Add(answer);
        }
    
        Console.WriteLine($"You listed {answers.Count} items! ");
        Console.WriteLine();
    
        return answers;
    }
}
        
       

        




 
