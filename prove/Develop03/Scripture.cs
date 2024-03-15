

public class Scripture
{
    // member variables 
    private Reference _reference; 

    private List<Word> _words; 

    private List<Word> _hiddenWords = new List<Word>();

    // constructors 

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;

        _words = ParseWords(text);


    }

    private List<Word> ParseWords(string text)
    {
        string[] wordArray = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        List<Word> words = new List<Word>();
        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
        return words;
    }



    // functions 

    public bool HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0 || numberToHide > _words.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(numberToHide), "Number of words to hide is invalid.");
        }
    
        Random random = new Random();
        HashSet<int> indicesToHide = new HashSet<int>();
        while (indicesToHide.Count < numberToHide)
        {
            int index = random.Next(_words.Count);
            indicesToHide.Add(index);
        }

        foreach (int index in indicesToHide)
        {
            _words[index].Hide();
            _hiddenWords.Add(_words[index]); // Add hidden word to _hiddenWords list
        }
    
        
        bool wordsHidden = false;
        foreach (int index in indicesToHide)
        {
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                wordsHidden = true;
            }
        }
        return wordsHidden;
    }


    public string GetDisplayText()
    {

        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);

    }
    
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void RestoreHiddenWords()
    {
        foreach (Word word in _hiddenWords)
        {
            word.Show(); // Set hidden flag to false
        }
        _hiddenWords.Clear(); // Clear the list after restoring
    }
    
}