using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{

    // AddRefferance(string book, string chapter, string startVerse, string endVerse = "")
    static void Main(string[] args)
    {  
        Scripture WorkAndGlory = new Scripture();
        WorkAndGlory.SetRefferance("Moses", "1", "39");
        WorkAndGlory.SetWords("For behold, this is my work and my glory—to bring to pass the immortality and eternal elife of man.");

        Scripture tenCommand = new Scripture();
        
        tenCommand.SetRefferance("Exodus", "20", "3", "17");
        tenCommand.SetWords("Thou shalt have no other gods before me. \nThou shalt not make unto thee any graven image, or any likeness of any thing that is in heaven above, or that is in the earth beneath, or that is in the water under the earth: \nThou shalt not bow down thyself to them, nor serve them: for I the Lord thy God am a jealous God, visiting the iniquity of the fathers upon the children unto the third and fourth generation of them that hate me; And shewing mercy unto thousands of them that love me, and keep my commandments. \nThou shalt not take the name of the Lord thy God in vain; for the Lord will not hold him guiltless that taketh his name in vain. \nRemember the sabbath day, to keep it holy. Six days shalt thou labour, and do all thy work: But the seventh day is the sabbath of the Lord thy God: in it thou shalt not do any work, thou, nor thy son, nor thy daughter, thy manservant, nor thy maidservant, nor thy cattle, nor thy stranger that is within thy gates: For in six days the Lord made heaven and earth, the sea, and all that in them is, and rested the seventh day: wherefore the Lord blessed the sabbath day, and hallowed it. Honor thy father and thy mother: that thy days may be long upon the land which the Lord thy God giveth thee. \nThou shalt not kill. \nThou shalt not commit adultery. \nThou shalt not steal. \nThou shalt not bear false witness against thy neighbour. \nThou shalt not covet thy neighbour's house, thou shalt not covet thy neighbour's wife, nor his manservant, nor his maidservant, nor his ox, nor his ass, nor any thing that is thy neighbour's.");

        Scripture nobalAndGreat = new Scripture();
        nobalAndGreat.SetRefferance("Abraham", "3", "22", "23");
        nobalAndGreat.SetWords("Now the Lord had shown unto me, Abraham, the intelligences that were organized before the world was; and among all these there were many of the noble and great ones; And God saw these souls that they were good, and he stood in the midst of them, and he said: These I will make my rulers; for he stood among those that were spirits, and he saw that they were good; and he said unto me: Abraham, thou art one of them; thou wast chosen before thou wast born.");

        Scripture chooseYeThisDay = new Scripture();
        chooseYeThisDay.SetRefferance("Joshua", "24", "15");
        chooseYeThisDay.SetWords("And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.");

        Scripture faith = new Scripture();
        faith.SetRefferance("Alma", "32", "21");
        faith.SetWords("And now as I said concerning faith— faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.");

        
        Dictionary<int, Scripture> _verseList = new Dictionary<int, Scripture>();
        _verseList.Add(1, WorkAndGlory);
        _verseList.Add(2, tenCommand);
        _verseList.Add(3, nobalAndGreat);
        _verseList.Add(4, chooseYeThisDay);
        _verseList.Add(5, faith);
               
        
        int count = 0;
        foreach ( var k in _verseList)
        {
            count += 1;
        }

        
       

        Random r = new Random();
        int _verseNum = r.Next(count);
        Scripture _todayVerse = _verseList[_verseNum];
       

        
        string key = "";
        string[] text = _todayVerse.GetWords();
        int textLength = text.Length;
        string[] blanks = new string[textLength];
        int wordCount = textLength;
        Random takeAway = new Random();
        
        while(wordCount > 0 || key != "quit")
        {
            blanks[takeAway.Next(textLength)] =  text[takeAway.Next(textLength)];
            blanks[takeAway.Next(textLength)] =  text[takeAway.Next(textLength)];
            blanks[takeAway.Next(textLength)] =  text[takeAway.Next(textLength)];

            Console.Write($"{_todayVerse.GetRefferance}");
            for (int i = 0; i < text.Length; i++)
            {
            
                if (!blanks.Contains(text[i]))
                {
                    Console.Write($"{text[i]} ");
                }
                else if (blanks.Contains(text[i]))
                {
                    int spaces = text[i].Length;
                    string result = new string('_' , spaces);
                    Console.Write($"{result} ");

                }
                else
                {
                    Console.WriteLine ("You broke it some how");
                }
                wordCount -= 3;
            }

            key = Console.ReadLine();
        }
    }
}