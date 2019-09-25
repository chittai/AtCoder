using System;

namespace ABC046
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            double res = K * Math.Pow(K - 1, N - 1);
            Console.WriteLine(res);
        }
    }
}
