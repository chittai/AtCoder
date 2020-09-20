using System;
using System.Linq;

namespace ABC042
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            string[] s = new string[N];
            for (int i = 0; i < N; i++)
            {
                s[i] = Console.ReadLine();
            }

            s = s.OrderBy(x => x).ToArray();

            string res = "";

            for (int i = 0; i < N; i++)
            {
                res += s[i];
            }

            Console.WriteLine(res);
        }
    }
}
