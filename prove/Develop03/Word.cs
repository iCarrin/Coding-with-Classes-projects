public class Word
{
    // private List<string> _scripture = new List<string> ();

    // public void SetScripture(string verses)
    // {
          
    //     foreach (string word in verses.Split(" ")) 
    //     {
    //         _scripture.Add(word);
        
    //     }
    // }

    // private Dictionary<int, string> _words = new Dictionary<int, string> ();
    
    private Array _words ;
    // public void AddScripture(string script)
    // {
    //     int count = 0;  
    //     foreach (string word in script.Split(" ")) 
    //     {
    //         _words.Add(count, word);
    //         count += count;
    //     }

        
    // }
    
    public void AddScripture(string script)
    {  
        string[] _words = script.Split();

    }

    // public Dictionary <int, string> GetScripture()
    // {
    //     return _words;
    // }

    public Array GetScripture()
    {
        return _words;
    }
    public int FindDictRange ()
    {
        int count = 0;
        foreach ( KeyValuePair <int, string> k in _words)
        {
            count += 1;
        }

        return count;
    }
}