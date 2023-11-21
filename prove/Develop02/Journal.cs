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

    public void AddEntry(Entry bigManInTheBack)
    {
        _entries.Add(bigManInTheBack);  
        // Entry placeHolderName = new Entry();
        // Console.WriteLine($"{placeHolderName._prompt}\n>");
        // placeHolderName._entryText = Console.ReadLine();

        // journal1.AddEntry(placeHolderName);

        //     Console.WriteLine(placeHolderName);  
    }

    public void SaveToFile()
    {

    }

    public void ReadFile()
    {
        
    }


    
}