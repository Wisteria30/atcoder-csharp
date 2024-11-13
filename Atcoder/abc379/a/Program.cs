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
            string N = Console.ReadLine();
            string bca = N[1].ToString() + N[2].ToString() + N[0].ToString();
            string cab = N[2].ToString() + N[0].ToString() + N[1].ToString();

            Console.WriteLine($"{bca} {cab}");
        }
    }
}
