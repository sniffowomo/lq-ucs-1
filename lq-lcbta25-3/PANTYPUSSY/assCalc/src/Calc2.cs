// Calculator project from the tutorial 

using Pastel;
using System;
using System.Drawing;

namespace assCalc.src
{
    public class Calc2
    {
        // Header function 
        public static void Calc2Header()
        {
            Uti.PrintHeader("Calculator 2 - Assignment");
        }

        // Note the actual operations are coming from Calc.cs
        public static void Calc2App()
        {
            // Getting inputs, diplaying it and exiting
            Console.WriteLine("Enter the first number: ".Pastel(Color.Plum));
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ".Pastel(Color.Aqua));
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($@"
{"---------- INPUTS ----------".Pastel(Color.Blue)}            
Input1: {num1.ToString().Pastel(Color.Plum)}
Input2: {num2.ToString().Pastel(Color.Aqua)}
{"---------- INPUTS ----------".Pastel(Color.Blue)}
            ");

            // Getting required operations
            Console.WriteLine($@"
{"---------- CHOOSE OPERATION ----------".Pastel(Color.Blue)}
{"[A]ddition".Pastel(Color.Green)}
{"[S]ubtraction".Pastel(Color.Cyan)}
{"[M]ultiplication".Pastel(Color.Yellow)}
{"[D]ivision".Pastel(Color.Magenta)}
{"---------- CHOOSE OPERATION ----------".Pastel(Color.Blue)}
");
            var choice = Console.ReadLine().ToUpper();
            Console.WriteLine($@"
{"---------- CHOICE----------".Pastel(Color.Blue)}
Choice: {choice.Pastel(Color.Orange)}
{"---------- CHOICE----------".Pastel(Color.Blue)}
");
            if (choice == "A")
            {
                Console.WriteLine($@"
{"---------- ADDITION----------".Pastel(Color.Green)}
{Calc.Add(num1, num2).ToString().Pastel(Color.Green)}
{"---------- ADDITION----------".Pastel(Color.Green)}");
            }
            else if (choice == "S")
            {
                Console.WriteLine($@"
{"---------- SUBTRACTION----------".Pastel(Color.Cyan)}
{Calc.Subtract(num1, num2).ToString().Pastel(Color.Cyan)}
{"---------- SUBTRACTION----------".Pastel(Color.Cyan)}");
            }
            else if (choice == "M")
            {
                Console.WriteLine($@"
{"---------- MULTIPLICATION----------".Pastel(Color.Yellow)}
{Calc.Multiply(num1, num2).ToString().Pastel(Color.Yellow)}
{"---------- MULTIPLICATION----------".Pastel(Color.Yellow)}");
            }
            else if (choice == "D")
            {
                Console.WriteLine($@"
{"----------DIVISION----------".Pastel(Color.Magenta)}
{Calc.Divide(num1, num2).ToString().Pastel(Color.Magenta)}
{"----------DIVISION----------".Pastel(Color.Magenta)}");
            }
            else
            {
                Console.WriteLine("Bastard Wrong Choice".Pastel(Color.Red));
            }


            // Exiting operation
            // Console.WriteLine("Press any key to exit".Pastel(Color.Peru));
            // Console.ReadKey();
            // Console.WriteLine("Exiting...".Pastel(Color.Yellow));

        }
    }
}
