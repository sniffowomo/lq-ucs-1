// Utility functions here 

using Pastel;
using System;
using System.Drawing;

namespace works2.src
{
    public class Uti
    {
        public static void PrintHeader(string header)
        {
            Console.WriteLine($@"
{"───── ⋆⋅☆⋅⋆ ─────".Pastel(Color.DarkRed)}
{header.Pastel(Color.Cyan)}
{"───── ⋆⋅☆⋅⋆ ─────".Pastel(Color.DarkRed)}");
        }

        public static void PrintHeader2(string header)
        {
            Console.WriteLine($@"
{"───── ".Pastel(Color.DarkViolet)}
{header.Pastel(Color.Cyan)}
{"───── ".Pastel(Color.DarkViolet)}");
        }
    }
}