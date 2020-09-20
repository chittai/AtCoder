using System;

namespace ABC022
{
    class B
    {
        static void Main(string[] args)
        {
            int X = 100000;
            int N = int.Parse(Console.ReadLine());
            int[] Res = new int[100000 + 1];

            for (int i = 1; i < N + 1; i++)
            {
                int A = int.Parse(Console.ReadLine());
                Res[A]++;
            }

            int res = 0;
            for (int i = 1; i < X + 1; i++)
            {
                if (2 <= Res[i]) { res += Res[i] - 1; }
            }
            Console.WriteLine(res);
        }
    }
}
