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

            int xi = n[2];

            for (int i = 0; i < 10; i++)
            {
                xi = (xi * n[0]) - n[1];
                Console.WriteLine(xi);
            }
        }
    }
}
