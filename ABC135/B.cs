using System;
using System.Linq;

namespace ABC135
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] array = new int[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            int conut = 0;
            for (int i = 0; i < N; i++)
            {
                if (array[i] != i + 1) conut++;
            }

            if (conut == 0 || conut == 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
