using System.Dynamic;

public class Scripture
{
    private Refferance _bookPlace = new Refferance();
    private Word _verses = new Word();

    public void SetRefferance(string book, string chapter, string startVerse, string endVerse = "")
    {
        _bookPlace.AddRefferance(book, chapter, startVerse, endVerse);
    }

    public string ReturnReffeance()
    {
        
        return _bookPlace.GetReffeance();
    }

    public void SetWords(string words)
    {
        _verses.AddScripture(words);
    }

    // public Dictionary <int, string> GetWords()
    // {
    //     return _verses.GetScripture();
    // }
   
   public Array GetWords()
    {
        return _verses.GetScripture();
    }

    public int RandomWord()
    {
        Random rando = new Random( );
        return rando.Next(_verses.FindDictRange());
    }

}