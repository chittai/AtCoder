using System;
using System.Linq;

namespace ABC088
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = int.Parse(input[i]);
            }

            a = a.OrderByDescending(x => x).ToArray();

            int alicepoint = 0;
            int bobpoint = 0;

            for (int i = 0; i < N; i++)
            {
                if ((i % 2) != 0)
                {
                    bobpoint += a[i];
                }
                else
                {
                    alicepoint += a[i];
                }
            }
            Console.WriteLine(alicepoint - bobpoint);
        }
    }
}
