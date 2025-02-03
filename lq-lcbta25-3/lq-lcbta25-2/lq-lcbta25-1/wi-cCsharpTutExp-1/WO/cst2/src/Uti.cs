using System;

namespace cst2.src
{
    public class Uti
    {
        //Label Printer 
        public static void Label1(string label)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"===
{label}
===");
            Console.ResetColor();
        }

    }
}