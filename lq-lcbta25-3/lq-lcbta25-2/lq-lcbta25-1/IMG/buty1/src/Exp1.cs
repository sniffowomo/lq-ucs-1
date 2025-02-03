// Csharp with the experiment files 
using Pastel;
using System.Drawing;

namespace buty1.src
{
    class Experiment1
    {
        public static void Exp1()
        {
            var colors = new[] {
                Color.Red,
                Color.Aqua,
                Color.BlanchedAlmond,
                Color.BlueViolet };
            foreach (var color in colors)
            {
                Console.WriteLine("Hello World!".Pastel(color));
            }
        }
    }
}