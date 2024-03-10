

public class PromptGenerator 
{
    // member variables 
    public List<string> _prompt; 

    // contructor 

    public PromptGenerator()
    {
        _prompt = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you learn from the scriptures today?",
        };

    }

    // methods or functions 

    public string GetRandomPrompt()
    {

        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _prompt.Count);

        // Return the prompt at the random index
        return _prompt[randomIndex];
    }




        //return "";
        /* foreach (string prompt in _prompt)
        {
            Console.WriteLine(prompt.) 
        }*/
    




}