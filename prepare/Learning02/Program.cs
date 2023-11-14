using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "Duck's Lemonade";
        job1._jobTitle = "Grape Salesman";
        job1._startYear = 2009;
        job1._endYear = 2023;
        
        Job job2 = new Job();
        job2._company = "Nyan Transportations";
        job2._jobTitle = "Pop Tart Pilot";
        job2._startYear = 2011;
        job2._endYear = 2023;

        // Console.WriteLine(job1._company);
        // Console.WriteLine(job2._company);

        // job1.Display();
        // job2.Display();

        Resume resume1 = new Resume();
        resume1._name = "Tom";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Console.WriteLine(resume1._jobs[0]._jobTitle);

        resume1.Display();
    }

}