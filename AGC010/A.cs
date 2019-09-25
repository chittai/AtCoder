using System;
using System.Linq;

namespace AGC010
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] n = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (n[i] % 2 != 0) count++;
            }

            if (count % 2 != 0) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
    }
}
