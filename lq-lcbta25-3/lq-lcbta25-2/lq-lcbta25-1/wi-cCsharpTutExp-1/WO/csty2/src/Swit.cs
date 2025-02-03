// Switch statements 

namespace csty2.src
{
    public class Swit
    {
        // Switch statement 1 - Study here
        public static void Switch1()
        {
            Utils.Label2("Swith Statement1");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Enter day numer between 1 and 7: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.Trim();

            // Validate input
            if (!int.TryParse(input, out int dayNumber) || dayNumber < 1 || dayNumber > 7)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed; Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
                Console.ResetColor();
                return;
            }

            string dayName = "";
            switch (input)
            {
                case "1":
                    dayName = "Monday";
                    break;
                case "2":
                    dayName = "Tuesday";
                    break;
                case "3":
                    dayName = "Wednesday";
                    break;
                case "4":
                    dayName = "Thursday";
                    break;
                case "5":
                    dayName = "Friday";
                    break;
                case "6":
                    dayName = "Saturday";
                    break;
                case "7":
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid input";
                    break;
            }
            Console.WriteLine($"Day {dayNumber} is {dayName}");
        }
    }
}