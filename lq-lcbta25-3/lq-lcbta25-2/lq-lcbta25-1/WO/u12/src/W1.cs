// 1st Execercise 

using System;

namespace u12.src
{
    public class Work1
    {
        // Function 1
        public static void Func1()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello World! From .. Press any button to exit");
            Console.ReadKey();
            Console.ResetColor();
        }

        // Testing multi assigment
        public static void Func2()
        {
            int a = 1, b = 2, c = 3;
            string name = "Booty", lastname = "Dancer";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(a + " " + b + " " + c);
            Console.WriteLine(name + " " + lastname);
            Console.ResetColor();
        }

        //Var and Implicit and explicit variables
        public static void Func3()
        {

            // Var realated
            // var name = "Booty"; name = ""; name = "";
            // string name2 = "Booty";
            // string name3 = "Booty";

            // Equalityies 

            var userChoice = "candy";
            System.Console.WriteLine();
            bool isUserInputAbc = userChoice == "abc";

        }

        // Conditional
        public static void Func4()
        {
            Utils.Label1("Conditionals");
            Console.WriteLine("Enter Text to evaluate : ");
            var userChoice = Console.ReadLine();
            if (userChoice == "a")
            {
                Console.WriteLine("A");
            }
            else if (userChoice == "b")
            {
                Console.WriteLine("B");
            }
            else
            {
                Console.WriteLine("C");
            }

        }

        // Scopes of variables
        public static void Func5()
        {
            Utils.Label1("Scopes");
            Console.WriteLine("Enter Text to evaluate : ");
            var userChoice = Console.ReadLine();

            if (userChoice.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Empty Fukr" + userChoice);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Not Empty Fukr" + userChoice);
                Console.ResetColor();
            }
            Console.WriteLine("Ur Choice = " + userChoice);
        }
    }
}