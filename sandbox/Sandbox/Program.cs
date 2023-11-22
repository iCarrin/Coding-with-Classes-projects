using System;

class Program
{
    static void Main(string[] args)
    {
        string[] split;
        string words = "Hi, my name is carl";

        split = words.Split();

        Console.WriteLine(split);
        

        // Console.WriteLine(split[0]);
        // Console.WriteLine(split[1]);
        // Console.WriteLine(split[2]);
        // Console.WriteLine(split[3]);
        // Console.WriteLine(split[4]);
        
        for (int i = 0; i < split.Length; i++)
        {
          
            
            if (i < 3) 
            {
                Console.Write(split[i]);
            }
        }
    }
}