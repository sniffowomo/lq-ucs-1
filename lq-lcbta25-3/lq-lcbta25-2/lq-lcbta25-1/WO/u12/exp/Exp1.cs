// Experiments section 

using u12.src;

namespace u12.exp
{
    public class Exp1
    {
        //First Letter of word is colored
        public static void FirstLetterColored()
        {
            Utils.Label1("First Letter Colored Program");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[?] Enter Word whose caps you want colored : ");
            Console.ResetColor();
            string? word = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(word?[0]);
            Console.ResetColor();

            Console.WriteLine(word?[1..]);
            Helperz.EndMessage();

        }

        public static void SentenceColored()
        {
            Utils.Label1("Coloring Sentence");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[?] Enter Word whose caps you want colored : ");
            Console.ResetColor();
            // Defining sentence to breakdown 
            string? colorWords = Console.ReadLine();

            // Defining an array with split words
            string[] words = colorWords.Split(' ');

            // Defining Colors 
            ConsoleColor[] wordColors = {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan,
                ConsoleColor.White
            };

            // Creating instance for random
            Random random = new();

            foreach (string word in words)
            {
                Console.ForegroundColor = wordColors[random.Next(0, wordColors.Length)];
                Console.Write(word + " ");
                Console.ResetColor();
            }
            Console.WriteLine();

            Helperz.EndMessage();
        }

        // This can be further optimized with and if-else ans switch statements
        public static void WhileLoop1()
        {
            Utils.Label1("While Loop Testing");

            string? keyChoice;

            do
            {
                Console.WriteLine("[?] Enter Text to evaluate (q to exit): ");
                keyChoice = Console.ReadLine()?.Trim();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"[+] U enetered (Etner q to exist) - {keyChoice}");
                Console.ResetColor();
            } while (keyChoice?.ToLower() != "q");
        }

        // Write new methods here
    }


    // -------- Helperz Functions Class-------- 
    public class Helperz
    {
        public static void EndMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[+] Executed Successfully");
            Console.ResetColor();
        }
    }
}
