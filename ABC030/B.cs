using System;
using System.Linq;

namespace ABC030
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            var degree = Math.Abs((6 * m) % 360 - (30 * n + 0.5 * m) % 360);
            Console.WriteLine(Math.Min(360 - degree, degree));
        }
    }
}
