using System;
using System.Net;
//using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> allNumbers = new List<int>();
        int sumAllNumbers = 0;
        int aveAllNumbers = 0;
        int largestNumber = 0;

        Console.Write("Give me a number (type \"0\" to stop)");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        allNumbers.Add (number);
        

        while (number != 0)
        {
            response = Console.ReadLine();
            number = int.Parse(response);
            allNumbers.Add (number);
        }

        foreach (int num in allNumbers)
        {
            sumAllNumbers += num;
        }

        aveAllNumbers = sumAllNumbers / allNumbers.Count;
        
        foreach (int num in allNumbers)
        {
            if (largestNumber < num)
            {
                largestNumber = num;
            }
            
        }

        Console.WriteLine($"The sum in {sumAllNumbers}");
        Console.WriteLine($"The average is {aveAllNumbers}");
        Console.WriteLine($"The largest is {largestNumber}");


    }
}