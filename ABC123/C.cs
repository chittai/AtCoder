using System;
using System.Linq;

namespace ABC123
{
    class C
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());

            long[] alpha = new long[5];

            for(long i = 0; i < alpha.Length; i++)
            {
                alpha[i] = long.Parse(Console.ReadLine());
            }
            
            double min = alpha.Min();
            double a = 4 + Math.Ceiling(N/min);

            long aa = (long)a;

            Console.WriteLine(aa);
        }
    }
}
