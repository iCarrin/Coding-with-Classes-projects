public class Entry 
{
    public DateTime _dateTime = DateTime.Now;

    public Prompt _randomPrompt.RandomPrompt();
    // not sure what's wrong here
    public string _entryText = Console.ReadLine();

    public void DisplayEntry(/*DateTime _dateTime, Prompt _randomPrompt, string _entryText*/)
    {
        Console.WriteLine($"{_dateTime} --- {_randomPrompt} \n{_entryText}");
    }
}