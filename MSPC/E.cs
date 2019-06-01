using System;

namespace MSPC
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            ulong Q = ulong.Parse(s);

            ulong x = 0;
            ulong d = 0;
            ulong n = 0;
            ulong result = 0;
            for (ulong i = 0; i < Q; i++)
            {
                result = 1;
                string[] s1 = Console.ReadLine().Split(' ');
                x = ulong.Parse(s1[0]);
                d = ulong.Parse(s1[1]);
                n = ulong.Parse(s1[2]);

                /*
                Console.WriteLine("x  " + x);
                Console.WriteLine("d  " + d);
                Console.WriteLine("n  " + n);
                */

                ulong X = 1000003;
                for (ulong j = 1; j <= n; j++)
                {
                    result *= x + (j - 1) * d;

                    //if (X <= result)
                    //   result -= X;
                }
                Console.WriteLine(result);
            }

        }
    }
}
