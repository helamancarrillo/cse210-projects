

public class Activity
{
    //member variables 

    private string _name; 

    private string _description; 

    protected int _duration; 

    // constructor 

    public Activity(string name, string description, int duration)
    {
        _name = name;

        _description = description; 

        _duration = duration;

    }

    // methods => functions 

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} ");
        Console.WriteLine();

        Console.WriteLine($"{_description} ");
        Console.WriteLine();

        Console.Write($"How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Get ready... ");
        ShowSpinner(5); 
   

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}."); 
        ShowSpinner(5);

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();

        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime) 
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++; 

            if (i >= animationStrings.Count)
            {
                i = 0;
            }

        } 

    }

    public void ShowCountDown(int seconds)
    {
        for (int c = seconds; c > 0; c--)
        {
            Console.Write(c);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 

        }


    }
}