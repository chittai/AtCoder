using System;
using System.Linq;

namespace ABC059
{
    class C
    {
        static void Main(string[] args)
        {

            long n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            Console.WriteLine(Math.Min(CalcA(a, true), CalcA(a, false)));
        }
        static long CalcA(long[] a, bool isP)
        {
            long result = 0;
            long sum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
                if (isP)
                {
                    if (sum <= 0) { result += 1 - sum; sum = 1; }
                }
                else
                {
                    if (0 <= sum) { result += 1 + sum; sum = -1; }
                }

                isP = isP ? false : true;

            }
            return result;
        }
    }
}

