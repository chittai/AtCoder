using System;

namespace ABC132
{
    class B
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] p = new int[n];
            for (int i = 0; i < n; i++)
            {
                p[i] = int.Parse(input[i]);
            }

            int[] tmp = new int[3];
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                tmp[0] = p[i - 1];
                tmp[1] = p[i];
                tmp[2] = p[i + 1];

                Array.Sort(tmp);

                if (p[i] == tmp[1]) { count++; }

            }
            Console.WriteLine(count);
        }
    }
}
