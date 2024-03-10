

using System.IO.Enumeration;

public class Journal
{
    // member variables 
    public List<Entry> _entries;

    //construct 

    public Journal()
    {
        _entries = new List<Entry>(); 

    }

    //methods or functions 
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);


    }


    public void DisplayAll()
    {

        foreach (Entry entrY in _entries)
        {
            entrY.Display();
            Console.WriteLine(); 
        }

    }

    public void SaveToFile(string file)
    {

        //Console.WriteLine("Enter the filename: ");
        //string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entrY in _entries)

            {
                string entryString = $"Date: {entrY._date}, - Prompt: {entrY._promptText}, - Answer: {entrY._entryText}";
                outputFile.WriteLine(entryString); 
                //outputFile.WriteLine(entrY);  
            }
                                   
        }

    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        //return loading; 

    }

}
