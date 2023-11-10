using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Give me a number");
        // string input = Console.ReadLine();
        // int magicNumber = int.Parse(input);
        
        Random randomGenorator = new Random();
        int magicNumber = randomGenorator.Next(1,100);
        


        int guess = 101;

        Console.WriteLine("Guess what number I'm thinking of. ");
        string input2 = Console.ReadLine();
        guess = int.Parse(input2);

        while (guess != magicNumber)
        {
            
            if (guess > magicNumber)
            {
                Console.WriteLine("Nope, Go lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Nope, Go higher");
            }
            else
            {
                Console.WriteLine("You got into the back rooms");
            }

            string input3 = Console.ReadLine();
            guess = int.Parse(input3);
            
        }
        if (guess == magicNumber)
            {
                Console.WriteLine($"You got it! the number was {magicNumber}");
            }
        
    }
}