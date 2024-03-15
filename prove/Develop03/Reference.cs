

using System.Collections.Concurrent;

public class Reference 
{
    //member variables
    
    private string _book; 

    private int _chapter; 

    private int _verse;

    private int _endVerse;

    //constructor

    public Reference(string book, int chapter, int verse)
    {

        _book = book; 

        _chapter = chapter; 

        _verse = verse; 

    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book; 

        _chapter = chapter; 

        _verse = verse; 

        _endVerse = endVerse;

    }

    // method => function 

    public string GetDisplayText() 
    {
        if (_endVerse == 0)
        {
            string displayT = $"{_book} {_chapter}:{_verse} "; 
            return displayT;

        }
        else 
        {
            string displayT = $"{_book} {_chapter}:{_verse}-{_endVerse} "; 
            return displayT;
        }


        
    }

    




}