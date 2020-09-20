using System;
using System.Linq;

namespace CADDi2018
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            if (0 < a.Count(x => x % 2 == 1)) Console.WriteLine("first");
            else Console.WriteLine("second");
        }
    }
}
