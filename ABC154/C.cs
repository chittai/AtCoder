using System;
using System.Linq;

namespace ABC154
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int Alen = A.Length;
            if (Alen == A.Distinct().ToArray().Length) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
    }
}
