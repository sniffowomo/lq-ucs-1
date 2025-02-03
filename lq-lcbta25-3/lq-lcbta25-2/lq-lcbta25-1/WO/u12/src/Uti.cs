// Utility Functions - Mostly for labelling
namespace u12.src
{
    public class Utils
    {
        // Main Lanel 
        public static void Label1(string l1)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($@"
------------------
{l1}
------------------");
            Console.ResetColor();
        }

        // Sub labels
        public static void Label2(string l2)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"------------------{l2}------------------");
            Console.ResetColor();
        }

    }
}