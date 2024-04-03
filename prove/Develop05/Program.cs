using System;

class Program
{
    static void Main(string[] args)
    {
        //instanciate working mas o menos 
        /*SimpleGoal first = new SimpleGoal("attend church", "go weekly", 10 , true); 
        Console.WriteLine(first.GetStringRepresentation());
        Console.WriteLine(first.RecordEvent()); 

        EternalGoal second = new EternalGoal("Read scriptures", "do it daily", 20 );
        Console.WriteLine(second.GetStringRepresentation());
        Console.WriteLine(second.RecordEvent());  

        ChecklistGoal third = new ChecklistGoal("sleep early","go to bed at 10 pm", 50, 3, 100);
        Console.WriteLine(third.GetDetailsString());
        Console.WriteLine(third.RecordEvent()); 

        */ 

        GoalManager first = new GoalManager(); 
        first.Start(); 
        

    }
}