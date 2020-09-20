using System;
using System.Linq;

namespace ABC098
{
    class C
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int[] WS = new int[N + 1];
            int[] ES = new int[N + 1];

            WS[0] = 0;
            ES[0] = 0;
            for (int i = 1; i < N + 1; i++)
            {
                if (S[i - 1] == 'W') { WS[i] = WS[i - 1] + 1; ES[i] = ES[i - 1]; }
                if (S[i - 1] == 'E') { ES[i] = ES[i - 1] + 1; WS[i] = WS[i - 1]; }
            }

            int[] res = new int[N + 1];

            for (int i = 0; i < N + 1; i++)
            {
                res[i] = WS[i] + ES[N] - ES[i];
            }

            Console.WriteLine(res.Min());
        }
    }
}
