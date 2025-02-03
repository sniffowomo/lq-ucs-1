// Loop statements 
namespace csty2.src
{
    public class Loops
    {
        public static void Loop1()
        {
            Utils.Label2("LoopStudy");

            // Simple Loop Operator
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
            Console.ResetColor();
        }

        // While Loop Function
        public static void Loop2()
        {
            Utils.Label2("While Loop");
            int i = 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            while (i <= 5)
            {
                Console.WriteLine($"Whiler Loop - Count: {i}");
                i++; // Important counter to prevent an infinite loop
            }
            Console.ResetColor();
        }
    }

    // Secondary class made for testing C#
    public class Lop2()
    {
        // Do while loops
        public static void Dowi()
        {
            Utils.Label2("Do While Loop");
            int i = 1;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            do
            {
                Console.WriteLine($"Do Whiler - Count: {i}");
                i++; // Important counter to prevent an infinite loop
            } while (i <= 5);
            Console.ResetColor();
        }

        // For each Loop Test - For Collections and Arrays
        public static void FoEa()
        {
            Utils.Label2("For Each Loop");
            int[] numbers = { 1, 2, 3, 4, 5 }; // This is an array
            foreach (int num in numbers)
            {
                Console.WriteLine($"For Each Loop - Count: {num}");
            }
        }
    }
}