#pragma warning disable 8602
#pragma warning disable 8600
using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (s.Contains('A') && s.Contains('B') && s.Contains('C'))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
