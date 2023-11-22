public class Refferance 
{
    // private string refferance;
    
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    public Refferance()
    {
        //this is so I don't have to add stuff the the "new Refferacne()" part
    }

    public Refferance(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startVerse;
        _verseEnd = "";
    }

    public Refferance(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = startVerse;
        if (endVerse != "")
        {
            _verseEnd = $"-{endVerse}";
        }
        else
        {
            _verseEnd ="";
        }
        
    }

    
     public void AddRefferance(string book, string chapter, string startVerse, string endVerse = "")
    {
       _book = book;
       _chapter = chapter;
       _verseStart = startVerse;
       _verseEnd = endVerse;
    }

    public string GetRefferance()
    {
        return $"{_book} {_chapter}:{_verseStart}{_verseEnd}";
    }
}