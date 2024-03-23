
public class BreathingActivity : Activity
{
    // member variable
       // there are not any :(

    // constructor 

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    } 

    // methods => functions 

    public void Run()
    {

        string title = @"
         ____                 _   _     _                            _   _       _ _         
        |  _ \               | | | |   (_)                 /\       | | (_)     (_) |        
        | |_) |_ __ ___  __ _| |_| |__  _ _ __   __ _     /  \   ___| |_ ___   ___| |_ _   _ 
        |  _ <| '__/ _ \/ _` | __| '_ \| | '_ \ / _` |   / /\ \ / __| __| \ \ / / | __| | | |
        | |_) | | |  __/ (_| | |_| | | | | | | | (_| |  / ____ \ (__| |_| |\ V /| | |_| |_| |
        |____/|_|  \___|\__,_|\__|_| |_|_|_| |_|\__, | /_/    \_\___|\__|_| \_/ |_|\__|\__, |
                                                 __/ |                                  __/ |
                                                |___/                                  |___/ 
               
        ";

        Console.WriteLine(title);


        int elapsedTime = 0;
    
        
        DisplayStartingMessage();
    
        
        while (elapsedTime < _duration)
        {
            // Breath in
            Console.Write("Breath in...");
            ShowCountDown(5); 
            elapsedTime += 5; 
            Console.WriteLine();
    
            
            if (elapsedTime >= _duration)
            {
                break; 
            }
    
            // Breath out
            Console.Write("Breath out...");
            ShowCountDown(5); 
            elapsedTime += 5; 
            Console.WriteLine();
        }
    
        
        DisplayEndingMessage();
        
    }

    //fun animation for exceeding the requirements 

} 