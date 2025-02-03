// Utility Functions
namespace csty2.src
{
    public class Utils
    {
        public static void Label1(string l1)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($@"
------------------
{l1}
------------------");
            Console.ResetColor();
        }

        public static void Label2(string l2)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"------------------{l2}------------------");
            Console.ResetColor();
        }

    }
}