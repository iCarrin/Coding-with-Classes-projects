public class Assignment
{
    private string _studentName;
    private string _topic;


    public Assignment (string studentName, string schoolTopic)
    {
        _studentName = studentName;
        _topic = schoolTopic;
    }
    public (string name, string topic) GetSummary()
    {
        return (_studentName,  _topic);
    }
}