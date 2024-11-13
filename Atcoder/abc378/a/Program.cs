#pragma warning disable 8602
using System;
using System.Collections.Generic;
using System.Linq;

namespace x
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] an = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] oneToFour = new int[4];
            foreach (var n in an)
            {
                oneToFour[n - 1]++;
            }

            var ans = 0;
            ans = oneToFour.Sum(i => i / 2);
            Console.WriteLine(ans);
        }
    }
}
