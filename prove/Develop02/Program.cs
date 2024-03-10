//to exceed the requirements there is a little
// program that ask the user for a reminder message
// to be display at a specific time, this is very helpful 
// becasue provides control to the user about the time
// its taking to use the journal program 



using System;

class Program
{
    static void Main(string[] args)
    {
        // welcome message
        Console.WriteLine("Welcome to the Journal Program!");
        //Console.WriteLine("Please select one of the following choices: ");


        // Prompt the user for reminder details
        Console.WriteLine("Please enter your reminder message:");
        string reminderMessage = Console.ReadLine();

        Console.WriteLine("Please enter the time for the reminder (HH:mm:ss):");
        string timeString = Console.ReadLine();
        DateTime reminderTime = DateTime.ParseExact(timeString, "HH:mm:ss", null);

        // Calculate the time delay until the reminder
        TimeSpan delay = reminderTime - DateTime.Now;

        // Set up a timer to trigger the reminder
        Timer timer = new Timer(state =>
        {
            // Display the reminder message
            Console.WriteLine($"Reminder: {reminderMessage}");

        }, null, delay, Timeout.InfiniteTimeSpan);

        Console.WriteLine("Reminder set. Press any key to exit.");
        Console.ReadKey();


        


        Journal journal = new Journal();

        // Loop for menu choices
        while (true)
        {
            // Display the menu
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        
            // Question to obtain the choice
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
        
            
            switch (choice)
            {
                case "1": // Write
                    // Prompt the user for entry details
                    //Console.Write("Enter the date: ");
                    string date = DateTime.Now.ToShortDateString();

                    // Generate a random prompt
                    PromptGenerator promptGenerator = new PromptGenerator();
                    promptGenerator = new PromptGenerator();
                    string promptText = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(promptText);
        
                    Console.Write("Enter the entry text: ");
                    string entryText = Console.ReadLine();
        
                    
        
                    // Create a new entry and add it to the journal
                    Entry newEntry = new Entry
                    {
                        _date = date,
                        _entryText = entryText,
                        _promptText = promptText
                    };
                    journal.AddEntry(newEntry);
        
                    Console.WriteLine("Entry added successfully.");
                    break;
        
                case "2": // Display
                    // Display all entries in the journal
                    journal.DisplayAll();
                    break;
        
                case "3": // Load
                    // Prompt the user for the file name
                    Console.Write("Enter the file name to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;
        
                case "4": // Save
                    // Prompt the user for the file name
                    Console.Write("Enter the file name to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
        
                case "5": // Quit
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;
        
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }


        

        


   
   

    }
}





//promptgenerator instances (need improvement)

        /*PromptGenerator second2 = new PromptGenerator();
        second2 = new PromptGenerator();
        string randomprompt = second2.GetRandomPrompt();
        // Console.WriteLine($"The random prompt: {randomprompt}");

        PromptGenerator second3 = new PromptGenerator();
        second2 = new PromptGenerator();
        string randompro = second3.GetRandomPrompt();

        // entry instances

        Entry first1 = new Entry();
        first1 = new Entry();
        first1._date = DateTime.Now.ToShortDateString(); 
        first1._entryText = "I will eat eggs";
        first1._promptText = randomprompt; 
        //first1.Display(); 

        Entry first2 = new Entry();
        first2 = new Entry();
        first2._date = DateTime.Now.ToShortDateString(); 
        first2._entryText = "The most interesting person was Ronaldo";
        first2._promptText = randompro; 
        //first2.Display();

        // journal instances 
        Journal journal = new Journal();

        journal = new Journal();

        journal.AddEntry(first1);
        journal.AddEntry(first2);

        journal.DisplayAll(); // probably will change 
        */