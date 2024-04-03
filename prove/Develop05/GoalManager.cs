
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.IO.Enumeration; 


public class GoalManager 
{
    // member variables
    private List<Goal> _goals; 

    private int _score; 

    //constructor 

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

    }

    // methods => functions 

    public void Start()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 8.");
                    break;
            }

            Console.WriteLine(); // Add a newline for better formatting
        }
    } 

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        int indexn = 0;
        Console.WriteLine("List of Goal Names:");
        foreach (var goal in _goals)
        {
            indexn++;
            Console.WriteLine($"{indexn} {goal.GetDetailsString()}"); 
        }
    }

    public void ListGoalDetails()
    {
        
        Console.WriteLine("List of Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetStringRepresentation()); 
        }
    }

    public void CreateGoal()
    {

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal ");
        Console.WriteLine("2. Eternal Goal ");
        Console.WriteLine("3. Checklist Goal ");

        Console.WriteLine("Which type of Goal would you like to create? ");
        string type = Console.ReadLine(); 

        if (type == "1" )
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points1 = int.Parse(Console.ReadLine());
    
            // by type
            Goal newGoal1 = new SimpleGoal(name, description, points1, false);
            _goals.Add(newGoal1);
        }
        else if (type == "2")
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points2 = int.Parse(Console.ReadLine());

            // by type
            Goal newGoal2 = new EternalGoal(name, description, points2);
            _goals.Add(newGoal2);

        }
        else if (type == "3")
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter goal description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points3 = int.Parse(Console.ReadLine());
            Console.Write("What is the target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the amount of bonus points associated with this goal? ");
            int bonus = int.Parse(Console.ReadLine());


            // by type
            Goal newGoal3 = new ChecklistGoal(name, description, points3, target, bonus);
            _goals.Add(newGoal3);

        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal have you completed?");
        ListGoalNames();
        Console.Write("Enter goal number: ");
        string goalNumber = Console.ReadLine(); 

        if (int.TryParse(goalNumber, out int index) && index >= 1 && index <= _goals.Count)
        {
            
            Goal completedGoal = _goals[index - 1];
            int pointsEarned = completedGoal.Pointsearned();
    
            
            _score += pointsEarned;

            Console.WriteLine($"Score: {_score}");
            
            Console.WriteLine(completedGoal.RecordEvent());
        }
        else
        {
            Console.WriteLine("Invalid goal number. Please enter a valid goal number.");
        }

        /*if (goalNumber == "1")
        {
            Console.WriteLine(_goals[0]);              
            Console.WriteLine(_goals[0].RecordEvent()); 
        }
        else if (goalNumber == "2")
        {
            Console.WriteLine(_goals[1].RecordEvent());
        }
        else if (goalNumber == "3")
        {
            Console.WriteLine(_goals[2].RecordEvent()); 
        } 
        */
      
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the name of the file? ");
        string file = Console.ReadLine();


        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Goal goal in _goals)

            {
                string entryString = goal.GetStringRepresentation(); 
                outputFile.WriteLine(entryString); 
                //outputFile.WriteLine(entrY);  
            }
                                   
        }
        
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file? ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

}