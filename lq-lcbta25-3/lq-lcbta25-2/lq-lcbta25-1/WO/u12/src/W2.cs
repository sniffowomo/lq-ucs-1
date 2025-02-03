//Contiuation from L28 
namespace u12.src
{
    public class Work2
    {
        public static void Func1()
        {
            // Part of this work is continued from exc1
            Utils.Label1("Method");

            Console.WriteLine(@"
Enter Text to evaluate : 
S = See all TODOs
A = Add TODO
R = Remove TODO
E = Exit
");
            var userChoice = Console.ReadLine()?.ToUpper();

            if (userChoice == "S")
            {
                Func1_Sub1("See all TODOs");
            }
            else if (userChoice == "A")
            {
                Func1_Sub1("Add TODO");
            }
            else if (userChoice == "R")
            {
                Func1_Sub1("Remove TODO");
            }
            else if (userChoice == "E")
            {
                Func1_Sub1("Exit");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Choice");
                Console.ResetColor();
            }
        }

        // This method is for Func1
        public static void Func1_Sub1(string selectedOption)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Seleted Option: " + selectedOption);
            Console.ResetColor();
        }

    }
}