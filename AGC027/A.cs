using System;
using System.Linq;

namespace AGC027
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int x = int.Parse(input[1]);

            int[] a = Console.ReadLine().Split().Select(int.Parse).OrderBy(y => y).ToArray();

            int count = 0;
            for (int i = 0; i < N; i++)
            {
                x -= a[i];
                if (0 <= x) count++;
                if (x < 0) break;
            }
            if (0 < x) count--;
            Console.WriteLine(count);
        }
    }
}
