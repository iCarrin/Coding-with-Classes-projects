using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("John Happypants", "intro to being cool");
        Console.WriteLine($"{test.GetSummary()}");

        var nameEClass = test.GetSummary();
        


        MathAssignment test2 = new MathAssignment(nameEClass.Item1, nameEClass.Item2, "section 23", "question 35");

        Console.WriteLine(test2.GetSummary());
        Console.WriteLine(test2.GetHomeworkList());

        WritingAssignment test3 = new WritingAssignment(test.GetSummary().Item1, test.GetSummary().Item2, "Is the Hokey Pokey Really what it's all about?");

        Console.WriteLine(test3.GetSummary());
        Console.WriteLine(test3.GetWritingInformation());

    }
}