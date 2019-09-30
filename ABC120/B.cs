using System;
using System.Collections.Generic;

namespace ABC120
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int K = int.Parse(input[2]);

            int n = CalcGCD(A, B);
            List<int> l = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                if (A % i == 0 && B % i == 0) { l.Add(i); }
            }

            Console.WriteLine(l[l.Count - K]);
        }

        static int CalcGCD(int A, int B)
        {
            if (B == 0) { return A; }

            return CalcGCD(B, A % B);
        }

    }
}
