// Main entry point 

using assCalc.src;
using Pastel;
using System.Drawing;

namespace assCalc
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            // SubPrograms.AssCalc();
            Calc2.Calc2Header();
            Calc2.Calc2App();

        }
    }
}

class SubPrograms
{
    public static void AssCalc()
    {
        Console.Clear();
        Uti.ColorPrint("Welcome to assCalc!!!!");

        // Calculator functions
        int add = Calc.Add(5, 5);
        int sub = Calc.Subtract(10, 5);
        int mul = Calc.Multiply(5, 5);
        int div = Calc.Divide(10, 5);

        Console.WriteLine($@"
Addition:       {add.ToString().Pastel(Color.Green)}
Subtraction:    {sub.ToString().Pastel(Color.Cyan)}
Multiplication: {mul.ToString().Pastel(Color.Yellow)}
Division:       {div.ToString().Pastel(Color.Magenta)}
".Trim());

        Uti.ColorPrint("Thank you for using assCalc!!!!");

    }
}

