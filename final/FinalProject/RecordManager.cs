
using System.Security.Cryptography.X509Certificates;

public class RecordManager
{
    //member variables

    //private string _name;

    //private int _age; 

    private List<Athlete> _records;

    // constructor 

    public RecordManager() //string name, int age
    {
        _records = new List<Athlete>();
    }

    //methods 

    public void Start()
    {

        Console.WriteLine("Welcome to the Athlete Record Calculator");
        Console.WriteLine();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Record");
            Console.WriteLine("2. Save Record");
            Console.WriteLine("3. Load Record");
            Console.WriteLine("4. Display Records");
            Console.WriteLine("5. Exit");
            

            Console.Write("Enter your number choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateRecord();
                    break;
                case "2":
                    SaveRecord();
                    break;
                case "3":
                    LoadRecord();
                    break;
                case "4":
                    DisplayRecords();
                    break;
                case "5":
                    running = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }

            Console.WriteLine(); 
        }

    }
 

    public void CreateRecord()
    {
        Console.WriteLine("The types of Sports are: ");
        Console.WriteLine("1. Track and Field ");
        Console.WriteLine("2. Swimming ");
        Console.WriteLine("3. Climbing ");
        Console.WriteLine("4. Cycling ");
        Console.WriteLine("5. Boxing ");
        Console.WriteLine("6. Skiing ");


        Console.WriteLine("Which type of Sport Record would you like to create? Enter the number* ");
        string type = Console.ReadLine(); 

        if (type == "1" )
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the distance in meters: ");
            int distanceInMeters = int.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            float timeInMinutes  = float.Parse(Console.ReadLine());
            
    
            
            SpeedRunner newrecord1 = new SpeedRunner(name, age, distanceInMeters, timeInMinutes);
            _records.Add(newrecord1);
        }
        else if (type == "2")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the swimming laps: ");
            int swimmingLaps = int.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            float timeInMinutes  = float.Parse(Console.ReadLine());

            
            SwimmerPace newrecord2 = new SwimmerPace(name, age, swimmingLaps, timeInMinutes);
            _records.Add(newrecord2);  

        }
        else if (type == "3")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the distance in meters: ");
            int distanceInMeters = int.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            float timeInMinutes  = float.Parse(Console.ReadLine());
            
    
            
            SpeedClimber newrecord3 = new SpeedClimber(name, age, distanceInMeters, timeInMinutes);
            _records.Add(newrecord3);

        }
        else if (type == "4")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the distance in meters: ");
            int distanceInMeters = int.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            float timeInMinutes  = float.Parse(Console.ReadLine());
            
    
            
            SpeedCyclist newrecord4 = new SpeedCyclist(name, age, distanceInMeters, timeInMinutes);
            _records.Add(newrecord4);

        }
        else if (type == "5")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the mass of your arm in kg: ");
            float mass = float.Parse(Console.ReadLine());
            Console.Write("Enter acceleration of the hit in m/s: ");
            float acceleration  = float.Parse(Console.ReadLine());
            
    
            
            Boxer newrecord5 = new Boxer(name, age, mass, acceleration);
            _records.Add(newrecord5);

        }
        else if (type == "6")
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the distance in meters: ");
            int distanceInMeters = int.Parse(Console.ReadLine());
            Console.Write("Enter the time in minutes: ");
            float timeInMinutes  = float.Parse(Console.ReadLine());
            
    
            
            SpeedSkier newrecord6 = new SpeedSkier(name, age, distanceInMeters, timeInMinutes);
            _records.Add(newrecord6);

        }
    }
    public void SaveRecord()
    {
        Console.WriteLine("What is the name of the file? ");
        string file = Console.ReadLine();
        
        ShowSpinner(3);
        

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Athlete athlete in _records)
            {
                string entryString = athlete.Record(); 
                outputFile.WriteLine(entryString); 
                //outputFile.WriteLine(entrY);  
            }
                                   
        }

        Console.WriteLine($"Your information have been saved in {file}.");
    }
    public void LoadRecord()
    {
        Console.WriteLine("What is the name of the file? ");
        string file = Console.ReadLine();
        string[] lines = File.ReadAllLines(file);
  
        ShowSpinner(3);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    public void DisplayRecords()
    {
        ShowCountDown(3);
        foreach (Athlete athlete in _records )
        {
            Console.WriteLine(athlete.Record()); 
        }
        
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
 