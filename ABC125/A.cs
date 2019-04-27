using System;
using System.Linq;

namespace ABC125
{
    class A
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int[] n = s.Select(x => int.Parse(x)).ToArray();

            int result = (n[2] / n[0]) * n[1];

            Console.WriteLine(result);
        }
    }
}
