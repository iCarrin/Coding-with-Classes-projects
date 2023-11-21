public class Entry 
{
    
    public string _date = DateTime.Now.ToString();
    
    public string _prompt = Prompt.GetRandomPrompt();
    
    public string _entryText;

    public string DisplayEntry()
    {
        Console.WriteLine($"~{_date} --- {_prompt} \n{_entryText}");
        return $"~{_date} --- {_prompt} \n{_entryText}";
    }
}