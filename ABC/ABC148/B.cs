using System;
using System.Linq;

namespace ABC148
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            string S = input[0];
            string T = input[1];
            string res = "";
            for (int i = 0; i < N; i++)
            {
                res += S[i];
                res += T[i];
            }

            Console.WriteLine(res);

        }
    }
}
