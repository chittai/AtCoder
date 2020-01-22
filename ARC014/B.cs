using System;
using System.Linq;

namespace ARC014
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] W = new string[N];
            for (int i = 0; i < N; i++)
            {
                W[i] = Console.ReadLine();
            }
            for (int i = 1; i < N; i++)
            {
                if (W[i][0] != W[i - 1][W[i - 1].Length - 1])
                {
                    if (i % 2 == 0) Console.WriteLine("LOSE");
                    else Console.WriteLine("WIN");
                    return;
                }
                for (int j = 0; j < i; j++)
                {
                    if (W[i] == W[j])
                    {
                        if (i % 2 == 0) Console.WriteLine("LOSE");
                        else Console.WriteLine("WIN");
                        return;
                    }
                }
            }
            Console.WriteLine("DRAW");
        }
    }
}
