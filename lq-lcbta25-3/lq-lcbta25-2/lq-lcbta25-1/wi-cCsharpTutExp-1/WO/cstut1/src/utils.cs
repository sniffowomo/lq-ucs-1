// Utilities class which will be called in program.cs 

using System;

namespace cstut1
{
    public class Uti
    {
        public static void Labeller(string label)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            // Accept input from the user
            Console.WriteLine(@$"
{label}
            ");
            Console.ResetColor();

        }
    }
}