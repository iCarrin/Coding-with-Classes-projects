public class WritingAssignment :Assignment
{
    private string _title;

    public WritingAssignment( string studentName, string schoolTopic, string paperTitle) : base (studentName, schoolTopic)
    {
        _title = paperTitle;
    }
    public string GetWritingInformation()
    {
        
        return ($"{_title} by {GetSummary().Item1}");
    }
}