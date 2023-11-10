using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("What is your first sname?");
        string FirstName = Console.ReadLine();
        Console.WriteLine("What is your first name?");
        string LastName = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}");
    }
}