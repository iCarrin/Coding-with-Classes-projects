using System.Dynamic;

public class Scripture
{
    private Refferance _bookPlace = new Refferance();
    private Word _verses = new Word();

    public void SetRefferance(string book, string chapter, string startVerse, string endVerse = "")
    {
        _bookPlace.AddRefferance(book, chapter, startVerse, endVerse);
    }

    public string GetRefferance()
    {
        
        return _bookPlace.GetRefferance();
    }

    public void SetWords(string words)
    {
        _verses.AddScripture(words);
    }

    // public Dictionary <int, string> GetWords()
    // {
    //     return _verses.GetScripture();
    // }
   
   public string[] GetWords()
    {
        return _verses.GetScripture();
    }

    public int RandomWord()
    {
        Random rando = new Random( );
        return rando.Next(_verses.FindLength());
    }

}