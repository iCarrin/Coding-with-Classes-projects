using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60 )
        {
            letter = "F";
        }
        else 
        {
            Console.Write("you got a into the back rooms");
        }

        Console.Write($"You got a {letter}! ");

        if (grade >= 70)
        {
            Console.Write("Congradulations you passed the class!!");
        }
        else if (grade < 70)
        {
            Console.Write("you failed the class this time. I'm sure with some practice you'll get it next time.");
        }
        else 
        {
            Console.Write("you found the backrooms ");
        }
    }   
}