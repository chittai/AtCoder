using System;
using System.Linq;

namespace ABC127
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            if (n[0] >= 13) Console.WriteLine(n[1]);
            if (6 <= n[0] && n[0] <= 12) Console.WriteLine(n[1] * 0.5);
            if (n[0] <= 5) Console.WriteLine(0);
        }
    }
}
