using System;
using System.Linq;

namespace ABC149
{
    class D
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int R = input[0];
            int S = input[1];
            int P = input[2];

            string T = Console.ReadLine();

            char[] k = new char[K];
            long res = 0;
            char next = ' ';
            for (int i = 0; i < N; i++)
            {

                if (i + K < N) next = T[i + K];
                else next = ' ';

                if (k[i % K] != 'p' && T[i] == 'r') { res += P; k[i % K] = 'p'; }
                else if (k[i % K] == 'p' && T[i] == 'r')
                {
                    if (next == 's') k[i % K] = 's';
                    else k[i % K] = 'r';
                }

                if (k[i % K] != 'r' && T[i] == 's') { res += R; k[i % K] = 'r'; }
                else if (k[i % K] == 'r' && T[i] == 's')
                {
                    if (next == 'p') k[i % K] = 'p';
                    else k[i % K] = 's';
                }


                if (k[i % K] != 's' && T[i] == 'p') { res += S; k[i % K] = 's'; }
                else if (k[i % K] == 's' && T[i] == 'p')
                {
                    if (next == 'r') k[i % K] = 'r';
                    else k[i % K] = 'p';
                }
            }
            Console.WriteLine(res);
        }
    }
}
