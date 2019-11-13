using System;
using System.Linq;

namespace AGC035
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long res = 0;
            for (int i = 0; i < N; i++)
            {
                res ^= a[i];
            }

            if (res == 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
