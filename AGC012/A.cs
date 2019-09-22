using System;
using System.Linq;

namespace AGC012
{
    class A
    {
        static void Main(string[] args)
        {
            long N = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            long i = 0;
            long l = a.Length - 2;

            long sum = 0;
            while (i < l)
            {
                sum += a[l];
                l = l - 2;
                i++;
            }

            Console.WriteLine(sum);
        }
    }
}
