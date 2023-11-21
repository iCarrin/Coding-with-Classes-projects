using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        string menu = "";

        while (menu != "5")
        {
            Console.Write("Please select one of the following choices\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nWhat would you like to do? ");
            menu = Console.ReadLine();

            if (menu == "1")
            {
                Entry entry1 = new Entry();
                Console.WriteLine($"{entry1._prompt}\n>");
                entry1._entryText = Console.ReadLine();


                journal1.AddEntry(entry1);
                entry1.DisplayEntry();
                // foreach (List<Entry> line in journal1._entries)
                // {
                //     Console.WriteLine(journal1._entries[line]);
                // }

                // foreach (Entry line in entry1)
                // {
                //     Console.WriteLine(entry1[line]);
                // }
                 
            }
            else if (menu == "2")
            {
                journal1.DisplayAll();
            }

            //save option
            else if (menu == "3")
            {
                Console.WriteLine("What would you like this journal to be called? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter ($"{fileName}.txt "))
                    foreach (Entry e in journal1._entries)
                    {
                        outputFile.WriteLine (e.DisplayEntry());
                    }
            }

            //reads the entries from a file
            else if (menu == "4")
            {
                Console.WriteLine("What Journal would you like to load? ");
                string journalName = Console.ReadLine();
                
                string[] journalEntries = System.IO.File.ReadAllLines($"{journalName}.txt ");
                foreach (string entry in journalEntries)
                    {
                        string[] parts = entry.Split("~");

                        Console.WriteLine(entry);
                    }
            }   

            //quit option
            else if (menu == "5")
            {
                System.Environment.Exit(0);
            }
            
            else 
            {
                Console.WriteLine("I'm sorry, try again");
            }
        }
    }
}