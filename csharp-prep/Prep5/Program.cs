using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int sqNum = SquareNumber(num);
        DisplayResults(name, sqNum);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static String PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }


    static int PromptUserNumber()
    {
       Console.WriteLine("What is your favorite number?");
       string favStringNum = Console.ReadLine();
       int favNumber = int.Parse(favStringNum);
       return favNumber;
    }

    static int SquareNumber(int favoriteNumber)
    {
        int favNumSq = favoriteNumber * favoriteNumber;
        return favNumSq;
    }
    static void DisplayResults(string name, int favNumSq)
    {
        Console.WriteLine($"{name} your favorite number squared is {favNumSq}");
    }
}