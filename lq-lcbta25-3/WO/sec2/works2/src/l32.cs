// Lesson 38 Work here 

using Pastel;
using System.Drawing;

namespace works2.src
{
    public class Lesson32
    {
        public static void MainFunc()
        {
            Uti.PrintHeader("Lesson 32 - Strings");
        }


        // Strings interpolation work here
        public static void String1()
        {
            Uti.PrintHeader2("String 1");
            // String 1 
            int a = 10, b = 20, c = 30;

            string s = "The values are " + a + ", " + b + ", and " + c;

            Console.WriteLine($"Strings in sequence - {a}, {b}, {c}".Pastel(Color.Yellow));

        }
    }
}