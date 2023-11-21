using System;

class Program
{
    static void Main(string[] args)
    {
        string words = "Hi, my name is carl";

        string[] split = words.Split();

        Console.WriteLine(words);

        foreach (string word in split)
        {
            Console.Write(word);
        }
    }
}