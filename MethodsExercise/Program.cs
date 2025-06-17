namespace MethodsExercise
{
    using System;
    using System.Collections.Generic;
    public class Program
    {

        public static List<string> words = new List<string>();
        public static string name;

        public static string lastType;
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            name = StartUp();
            SayHello();
        }
        static string StartUp()
        {
            Console.WriteLine("Hello There");
            Console.WriteLine("What is your name?");
            Console.WriteLine($"");
            string startName = Console.ReadLine();
            string convertedName = ConvertFormat(startName);
            return convertedName;
        }

        static string ConvertFormat(string name)
        {
            string nameEnd = name.Substring(1).ToLower();
            char firstLetter = char.ToUpper(name[0]);
            return firstLetter + nameEnd;
        }
        public static void SayHello()
        {
            Console.WriteLine($"");
            Console.WriteLine($"Well then {name}");
            Console.WriteLine("Do you want to play a game");
            
            bool doThey = YesNo();
            
            if (doThey == true)
            {
                Console.WriteLine($"");
                Console.WriteLine($"Great, {name}!");
                Console.WriteLine("Let's play then");
                RunGame();

            }else if (doThey == false)
            {
                end();
            }

        }

        public static void RunGame()
        {
            Console.WriteLine($"");
            Console.WriteLine("This Game Is Called MAD LIBS");
            Console.WriteLine("Your job is to give me words depending on the prompt");
            Console.WriteLine($"Are you Ready {name}?");
            bool areThey = YesNo();
            if (areThey == false)
            {
                end();
            }
            Console.WriteLine("Great!");
            GetWord("ADJECTIVE");
            GetWord("ADJECTIVE");
            GetWord("NOUN");
            GetWord("NOUN");
            GetWord("PLURAL NOUN");
            GetWord("GAME");
            GetWord("PLURAL NOUN");
            GetWord("VERB ENDING IN “ING”");
            GetWord("VERB ENDING IN “ING”");
            GetWord("PLURAL NOUN");
            GetWord("VERB ENDING IN “ING”");
            GetWord("NOUN");
            GetWord("PLANT");
            GetWord("PART OF THE BODY");
            GetWord("PLACE");
            GetWord("VERB ENDING IN “ING”");
            GetWord("ADJECTIVE");
            GetWord("NUMBER");
            GetWord("PLURAL NOUN");
            WriteMadLib();

        }

        public static void WriteMadLib()
        {
            Console.WriteLine($"Ok {name}");
            Console.WriteLine($"Here Goes");
            Console.WriteLine($"");
            PrintMadLibLine("A vacation is when you take a trip to some ", 0);
            PrintMadLibLine(" place with your ", 1);
            PrintMadLibLine(" family. Usually you go to some place that is near a/an ", 2);
            PrintMadLibLine(" or up on a/an ", 3);
            PrintMadLibLine(". A good vacation place is one where you can ride ", 4);
            PrintMadLibLine(" or play ", 5);
            PrintMadLibLine(" or go hunting for ", 6);
            PrintMadLibLine(". I like to spend my time ", 7);
            PrintMadLibLine(" or ", 8);
            PrintMadLibLine(". When parents go on a vacation, they spend their time eating three ", 9);
            PrintMadLibLine(" a day, and fathers play golf, and mothers sit around ", 10);
            PrintMadLibLine(". Last summer, my little brother fell in a/an ", 11);
            PrintMadLibLine(" and got poison ", 12);
            PrintMadLibLine(" all over his ", 13);
            PrintMadLibLine(". My family is going to go to (the) ", 14);
            PrintMadLibLine(", and I will practice ", 15);
            PrintMadLibLine(". Parents need vacations more than kids because parents are always very ", 16);
            PrintMadLibLine(" and because they have to work ", 17);
            PrintMadLibLine(" hours every day all year making enough ", 18);
            Console.Write(" to pay for the vacation.");
            
            

        }

        public static void PrintMadLibLine(string line, int num)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(line);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(words[num]);
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }

        public static string GetWord(string wordType)
        {
            if (wordType == lastType)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"");
                Console.Write($"Give Me Another ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(wordType);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"");
                Console.Write($"Give Me A/An ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(wordType);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"");
            }
            string wordGiven = Console.ReadLine();
            words.Add($"{wordGiven}");
            lastType = wordType;
            Console.ForegroundColor = ConsoleColor.Gray;
            return wordGiven;  
        }
        
        public static bool YesNo()
        {
            Console.WriteLine($"");
            Console.WriteLine("Type");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yes:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string Response = Console.ReadLine();
            if (Response.ToLower() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void end()
        {
            Console.WriteLine("All right then");
            Console.WriteLine("Goodbye");
            Environment.Exit(-1);
        }
        
    }
}
