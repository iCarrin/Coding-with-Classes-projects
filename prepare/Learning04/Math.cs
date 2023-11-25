public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment (string studentName, string schoolTopic, string sectionTextbook, string questionNum) : base(studentName, schoolTopic)
    {
        _textbookSection = sectionTextbook;
        _problems = questionNum;
    }
    public (string textbookSection, string problems) GetHomeworkList()
    {
        return (textbookSection: _textbookSection, problems: _problems);
    }
}