using System;
using System.Linq;

namespace ABC142
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(h.Count(x => K <= x));
        }
    }
}
