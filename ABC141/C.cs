using System;
using System.Collections.Generic;
using System.Text;

namespace ABC141
{
    class C
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int Q = int.Parse(input[2]);

            int[] P = new int[N];

            for (int i = 0; i < Q; i++)
            {
                int a = int.Parse(Console.ReadLine());
                P[a - 1] += 1;
            }

            for (int i = 0; i < N; i++)
            {
                if (K <= (Q - P[i])) { Console.WriteLine("No"); } else { Console.WriteLine("Yes"); }
            }
        }
    }
}