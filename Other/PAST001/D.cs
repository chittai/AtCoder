using System;
using System.Linq;

namespace PAST001
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                int a = int.Parse(Console.ReadLine()) - 1;
                A[a]++;
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == 0) x = i + 1;
                if (A[i] == 2) y = i + 1;
            }
            if (x == 0 && y == 0) Console.WriteLine("Correct");
            else Console.WriteLine("{0} {1}", y, x);
        }
    }
}
