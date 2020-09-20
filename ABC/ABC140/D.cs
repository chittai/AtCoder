using System;

namespace ABC140
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string s = Console.ReadLine();

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int socre = 0;
            for (int i = 1; i < N; i++)
            {
                if (s[i] == s[i - 1]) socre++;
            }

            Console.WriteLine(Math.Min(socre + 2 * K, N - 1));
        }
    }
}
