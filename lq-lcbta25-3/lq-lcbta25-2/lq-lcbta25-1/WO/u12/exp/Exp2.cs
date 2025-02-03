// Testing out Paste colors 

using Pastel;
using System;
using System.Drawing;
using u12.src;

namespace u12.exp
{
    public class Exp2
    {
        public static void ColorText1()
        {
            Utils.Label1("Testing out Paste colors");
            Console.WriteLine("This is a test of color text".Pastel(Color.DarkCyan));
            Console.WriteLine("This is a test of color text".Pastel(Color.WhiteSmoke));
            Console.WriteLine("This is a test of color text".Pastel(Color.FromArgb(165, 229, 250)));
        }

        public static void ColorTextWithInput()
        {
            Utils.Label1("Testing out Paste colors on inputs");
            Console.WriteLine("Enter ur Name: ");
            string colorName = Console.ReadLine()?.Trim();
            Console.WriteLine(
                "Name is " +
                colorName.Pastel(Color.YellowGreen)
                );
            Console.WriteLine($"Name is : {colorName.Pastel(Color.Bisque)} ");
        }
    }

}
