
using System.ComponentModel.DataAnnotations;

public class Entry 
{
    // member variable to obtain data

    public string _date = ""; 

    public string _promptText = ""; 

    public string _entryText = ""; 

    // constructor 
    public Entry()
    {

    }

    // methods o functions 

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText} ");
        Console.WriteLine(_entryText); 

    }


}