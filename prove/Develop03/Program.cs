using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");

        // trying instances for each class 
        //Reference proving = new Reference("Helaman", 5, 12, 13);
        //Console.Write(proving.GetDisplayText());

        //Word proving2 = new Word("Helaman");
        //Console.WriteLine(proving2.GetDisplayText());  */ 

        //Scripture proving3 = new Scripture( proving , "I will go and do all things with Christ");
        //proving3.HideRandomWords(3);
        //proving3.IsCompletelyHidden();
        //Console.WriteLine(proving3.GetDisplayText()); 

        Reference reference = new Reference("Helaman", 5, 12);
        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no bcommandments unto the children of men, save he shall cprepare a way for them that they may accomplish the thing which he commandeth them.";

        
        Scripture scripture = new Scripture(reference, text);

        
        Console.Write($"{reference.GetDisplayText()}");
        Console.WriteLine($"{scripture.GetDisplayText()}");


        bool wordsHidden = false;

        while (true)
        {
            Console.WriteLine(wordsHidden ? "Press Enter to continue hiding words, type 'restore' to restore hidden words, or type 'quit' to exit:" : "Press Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();
        
            if (input.ToLower() == "quit")
            {
                break; 
            }
            else if (input.ToLower() == "restore")
            {
                if (wordsHidden)
                {
                    
                    scripture.RestoreHiddenWords(); 
                    Console.Clear();
                    Console.WriteLine($"Reference: {reference.GetDisplayText()}"); 
                    Console.WriteLine($"Scripture: {scripture.GetDisplayText()}"); 
                }
                else
                {
                    Console.WriteLine("No words are currently hidden.");
                }
            }
            else if (input == "")
            {
                
                scripture.HideRandomWords(3); 
                wordsHidden = true;
                Console.Clear(); 
                Console.WriteLine($"Reference: {reference.GetDisplayText()}"); 
                Console.WriteLine($"Scripture: {scripture.GetDisplayText()}"); 
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter to continue or type 'quit' to exit.");
            }
        }

 
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /*

        
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to hide a random word or type 'quit' to exit the program:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; 
            }
            else if (input == "")
            {
                
                scripture.HideRandomWords(3);

                
                Console.Clear();
                Console.Write($"{reference.GetDisplayText()}");
                Console.WriteLine($" {scripture.GetDisplayText()}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } */ 

        Console.WriteLine("Program exited.");
    }
}


        





        
