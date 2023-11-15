using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
        }
    } 

    public void AddEntry()
    {
        // public Entry _newEntry = new Entry(); 
        // public Entry
    }

    public void SaveToFile()
    {

    }

    public void ReadFile()
    {
        
    }


    
}